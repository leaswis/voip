using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ozeki.Media;
using Ozeki.Media.MediaHandlers;
using Ozeki.Network.Nat;
using Ozeki.VoIP;
using Ozeki.VoIP.SDK;
using Ozeki.Common;
using System.Threading;
using Ozeki.Media.Codec;

namespace SoftphoneV2
{
    class Softphone
    {
        ISoftPhone softphone;   // softphone object
        IPhoneLine phoneLine;   // phoneline object
        IPhoneCall call;                        // the call object
        Microphone microphone;
        Speaker speaker;
        MediaConnector connector;               // connects the devices to each other (eg. microphone, speaker, mediaSender, mediaReceiver)
        PhoneCallAudioSender mediaSender;       // after connected with the microphone, this will be attached to the call
        PhoneCallAudioReceiver mediaReceiver;

        bool incomingCall;

        public event EventHandler IncomingCall;
        public event EventHandler<RegistrationStateChangedArgs> PhoneLineStateChanged;
        public event EventHandler<CallStateChangedArgs> CallStateChanged;

        public Softphone()
        {
            softphone = SoftPhoneFactory.CreateSoftPhone(5000, 10000);
            microphone = Microphone.GetDefaultDevice();
            speaker = Speaker.GetDefaultDevice();
            connector = new MediaConnector();
            mediaSender = new PhoneCallAudioSender();
            mediaReceiver = new PhoneCallAudioReceiver();

            incomingCall = false;
        }

        public void Register(bool registrationRequired, string displayName, string userName, string authenticationId, string registerPassword, string domainHost, int domainPort)
        {
            try
            {
                // To register to a PBX, we need to create a SIP account
                var account = new SIPAccount(registrationRequired, displayName, userName, authenticationId, registerPassword, domainHost, domainPort);
                Console.WriteLine("\nCreating SIP account {0}", account);

                // With the SIP account and the NAT configuration, we can create a phoneline.
                phoneLine = softphone.CreatePhoneLine(account);
                Console.WriteLine("Phoneline created.");
                // The phoneline has states, we need to handle the event, when it is being changed.
                phoneLine.RegistrationStateChanged += phoneLine_PhoneLineStateChanged;

                // If our phoneline is created, we can register that.
                softphone.RegisterPhoneLine(phoneLine);

                ConnectMedia();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during SIP registration: " + ex.ToString());
            }
        }

        private void phoneLine_PhoneLineStateChanged(object sender, RegistrationStateChangedArgs e)
        {
            var handler = PhoneLineStateChanged;
            if (handler != null)
                handler(this, e);
        }

        public void TransferTo(string target)
        {
            if (call != null && !string.IsNullOrEmpty(target))
            {
                call.BlindTransfer(target);
            }
        }

        private void StartDevices()
        {
            if (microphone != null)
            {
                microphone.Start();
            }

            if (speaker != null)
            {
                speaker.Start();
            }
        }
        private void StopDevices()
        {
            if (microphone != null)
            {
                microphone.Stop();
            }

            if (speaker != null)
            {
                speaker.Stop();
            }
        }
        private void ConnectMedia()
        {
            if (microphone != null)
            {
                connector.Connect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Connect(mediaReceiver, speaker);
            }
        }
        private void DisconnectMedia()
        {
            if (microphone != null)
            {
                connector.Disconnect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Disconnect(mediaReceiver, speaker);
            }

            // You can close all of the connections by using: connector.Dispose();
        }

        private void WireUpCallEvents()
        {
            call.CallStateChanged += (call_CallStateChanged);
        }
        private void WireDownCallEvents()
        {
            call.CallStateChanged -= (call_CallStateChanged);
        }

        private void softphone_IncomingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            call = e.Item;
            WireUpCallEvents();
            incomingCall = true;

            DispatchAsync(() =>
            {
                var handler = IncomingCall;
                if (handler != null)
                    handler(this, EventArgs.Empty);
            });
        }

        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            // the call has been answered
            if (e.State == CallState.Answered)
            {
                StartDevices();

                mediaReceiver.AttachToCall(call);
                mediaSender.AttachToCall(call);
            }

            // the call is in active communication state
            // IMPORTANT: this state can occur multiple times. for example when answering the call or the call has been taken off hold.
            if (e.State == CallState.InCall)
            {
                StartDevices();
            }

            // the call has ended
            if (e.State.IsCallEnded())
            {
                if (call != null)
                {
                    CallFinished();
                }
            }

            DispatchAsync(() =>
            {
                var handler = CallStateChanged;
                if (handler != null)
                    handler(this, e);
            });
        }

        public void StartCall(string numberToDial)
        {
            if (call == null)
            {
                call = softphone.CreateCallObject(phoneLine, numberToDial);
                WireUpCallEvents();

                // To make a call simply call the Start() method of the call object.
                call.Start();
            }
        }

        public void AcceptCall()
        {
            // when the value of the incomingCall member is true, there is an incoming call
            if (incomingCall)
            {
                incomingCall = false;
                call.Answer();
            }
        }

        public void HangUp()
        {
            if (call != null)
            {
                call.HangUp();
                call = null;
            }
        }

        public void HoldCall()
        {
            if (call != null)
            {
                call.ToggleHold();
            }
        }
        public void CallFinished()
        {
            StopDevices();

            mediaReceiver.Detach();
            mediaSender.Detach();

            WireDownCallEvents();

            call = null;
        }

        private void DispatchAsync(Action action)
        {
            var task = new WaitCallback(o => action.Invoke());
            ThreadPool.QueueUserWorkItem(task);
        }

        public IEnumerable<CodecInfo> Codecs()
        {
            return softphone.Codecs;
        }

        public void EnableCodec(int codec)
        {
            softphone.EnableCodec(codec);
        }

        public void DisableCodec(int codec)
        {
            softphone.DisableCodec(codec);
        }
    }
}
