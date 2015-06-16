using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SoftphoneV2;
using Ozeki.Media;
using Ozeki.Media.MediaHandlers;
using Ozeki.Network.Nat;
using Ozeki.VoIP;
using Ozeki.VoIP.SDK;
using Ozeki.Common;
using Ozeki.Media.Codec;

namespace Komunikator
{
    public partial class Rozmowa : Form
    {

        ImageAd obraz = new ImageAd();
        UserInterest user_interest = new UserInterest();
        int loggedUser;

        Logic logic = new Logic();

        public Rozmowa(int dataReceived)
        {
            User_info info = new User_info();
            InitializeComponent();

            loggedUser = dataReceived;

            logic.DisplayUserInfo(info, loggedUser);
            string name = info.Name;
            labelName.Text = "Witaj " + name + "!";


            int[] list = takeListInterest(user_interest, loggedUser);

            displayAdds(obraz, list); 
            
            List<int> contacts = logic.GetContacts(loggedUser);
            List<string> names = new List<string>();
            foreach (int i in contacts) 
            {
                User_info temp_userinfo = new User_info();
                logic.DisplayUserInfo(temp_userinfo, i);
                comboBox1.Items.Add(temp_userinfo.Name + " " + temp_userinfo.Surname);
            }
            comboBox1.SelectedIndex = 0;
            InitializeComponent();
            
        }

        private async void displayAdds(ImageAd img, int[] list)
        {
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            while (true)
            {
                foreach (int i in list)
                {
                    using (var dbContext = new LinqClassesDataContext())
                    {

                        var table = from t in dbContext.ImageAds
                                    where t.Id == i
                                    select t;

                        img.image = table.Single().image;

                        pictureBox1.Image = ByteArrayToImage(img.image.ToArray());
                        pictureBox1.Refresh();
                        await Task.Delay(1000);
                    }

                }
            }
        }



        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        public int[] takeListInterest(UserInterest usr, int userId)
        {

            using (var dbContext = new LinqClassesDataContext())
            {

                int[] list_interest = dbContext.UserInterests
                .Where(v => v.userID == userId)
                .Select(v => v.interestID).ToArray();

                return list_interest;

            }

        }


        private void Rozmowa_Load(object sender, EventArgs e)
        {
            //InitSoftphone();
            //RegisterInfos();
            textBox1.Text += "Load";
        }

        private static Softphone mySoftphone;
        private static string numberToCall;     // indicates the last called number. can be used for redialing.
        private static string numberToTransfer;
        private static string exampleSteps; 
        /// <summary>
        
        


        private void InitSoftphone()
        {
            mySoftphone = new Softphone();
            mySoftphone.PhoneLineStateChanged +=  mySoftphone_PhoneLineStateChanged;
            mySoftphone.CallStateChanged += mySoftphone_CallStateChanged;
            mySoftphone.IncomingCall += mySoftphone_IncomingCall;
            
            numberToTransfer = string.Empty;
            numberToCall = string.Empty;
            exampleSteps = string.Empty;
        }



        private void mySoftphone_PhoneLineStateChanged(object sender, RegistrationStateChangedArgs e)
        {
           
            InvokeGUIThread(() => { textBox1.Text += "Phone line state changed:" + e.State; }); 
            
            
            if (e.State == RegState.Error || e.State == RegState.NotRegistered)
                RegisterInfos();

            if (e.State == RegState.RegistrationSucceeded)
            {
                 InvokeGUIThread(() => { textBox1.Text += "Registration succeeded - Online!"; }); 
                
                StartToDial();   
            }
        }

        void mySoftphone_IncomingCall(object sender, EventArgs e)
        {
           
            InvokeGUIThread(() => { textBox1.Text += "\nIncoming call!"; });
            InvokeGUIThread(() => { textBox1.Text += "Call accepted."; }); 
            
            mySoftphone.AcceptCall();
        }

        void mySoftphone_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            
            InvokeGUIThread(() => { textBox1.Text += "Call state changed:" + e.State; });
            if (e.State.IsCallEnded())
            {
                StartToDial();
            }
            /*
            if (e.State == CallState.Answered && exampleSteps == "Calling")
            {
                exampleSteps = "Held";
                mySoftphone.HoldCall();
                InvokeGUIThread(() => { log.Text += "\nThe call is: " + exampleSteps + " by the user!"; });
            }

            if (e.State == CallState.LocalHeld)
            {
                exampleSteps = "Unheld";
                Console.WriteLine("\nPress any key to take the call off hold.");
                Console.ReadKey();
                InvokeGUIThread(() => { log.Text += "\nThe call is: " + exampleSteps + " by the user!"; });
                mySoftphone.HoldCall();
            }

            if (e.State == CallState.InCall && exampleSteps == "Unheld")
            {
                exampleSteps = "HangedUp";
                InvokeGUIThread(() => { log.Text += "\nThe call is: " + exampleSteps + " by the user!"; });
                mySoftphone.HangUp();
            }

            if (e.State == CallState.Completed && exampleSteps == "HangedUp")
            {
                exampleSteps = "Redialed";
                Console.WriteLine("\nPress any key to redial.");
                Console.ReadKey();
                InvokeGUIThread(() => { log.Text += "\nThe call is: " + exampleSteps + " by the user!"; });
                mySoftphone.StartCall(numberToCall);
            }


            if (e.State == CallState.Answered && exampleSteps == "Redialed")
            {
                exampleSteps = "Transfering";
                mySoftphone.TransferTo(numberToTransfer);
                InvokeGUIThread(() => { log.Text += "\nThe call is: " + exampleSteps + " by the user!"; });
            }*/
        }

        private void RegisterInfos()
        {
            
            var registrationRequired = false;
            
            // The SIP account needs and authentication ID, and some names as well.
            var authenticationId = "linkin";

            // If the user only presses the Enter button, the username will be the same as the authentication ID
            var userName = "linkin";
            if (string.IsNullOrEmpty(userName))
                userName = authenticationId;

            // If the user only presses the Enter button, the display name will be the same as the authentication ID
            var displayName = "linkin";
            if (string.IsNullOrEmpty(displayName))
                displayName = authenticationId;

            // The registration password needs to be entered.
            var registerPassword = "linkin";

            // Domain name as a string, for example an IP adress.
            var domainHost = "192.168.1.1";

            // Port number with the as 5060 default value.
            int domainPort;
            string port = "5060";
            if (string.IsNullOrEmpty(port))
            {
                domainPort = 5060;
            }
            else
            {
                domainPort = Int32.Parse(port);
            }
            
            // When every information has been given, we are trying to register to the PBX with the softphone's Register() method.
            mySoftphone.Register(registrationRequired, displayName, userName, authenticationId, registerPassword, domainHost, domainPort);
        }

        


        /// <summary>
        /// This method will display the names of the enabled codecs on the consol.
        /// </summary>
        private static void WriteEnabledCodecs()
        {
            Console.WriteLine("\nEnabled codecs:");
            foreach (var codecInfo in mySoftphone.Codecs())
            {
                if (codecInfo.Enabled == true)
                {
                    Console.WriteLine("{0,3} {1}", codecInfo.PayloadType, codecInfo.CodecName);
                }
            }
        }

        private void StartToDial()
        {
            
            InvokeGUIThread(() => { textBox1.Text += "\nTo start a call, type the number and press Enter: "; });
            /*string numberToDial = Console.ReadLine();
            while (string.IsNullOrEmpty(numberToDial))
            {
                numberToDial = Console.ReadLine();
            }*/
            //mySoftphone.StartCall(numberToDial);
            mySoftphone.StartCall("192.168.1.2");
            
        }
        
        private void InvokeGUIThread(Action action)
        {
            Invoke(action);
    
        }

        


        
    }
}
