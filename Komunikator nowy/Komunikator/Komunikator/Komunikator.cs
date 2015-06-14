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
//using System.Threading;



namespace Komunikator
{
    public partial class Komunikator : Form
    {
        ImageAd obraz = new ImageAd();
        UserInterest user_interest = new UserInterest();
        int loggedUser;
        List<int> interest_list = new List<int>();

        Logic logic = new Logic();

        //List<Image> list = new List<Image>();

        public Komunikator(int dataReceived)
        {
            User_info info = new User_info();
            InitializeComponent();

            loggedUser = dataReceived;

            logic.DisplayUserInfo(info, loggedUser);
            string name = info.Name;
            labelHello.Text = "Witaj " + name + "!";

            
            int[] list = takeListInterest(user_interest, loggedUser);

            displayAdds(obraz, list);
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

                public List<int> takeInterest(UserInterest uintr, int userId)
        {
            List<int> a = new List<int>();
            logic.LoadInterestId(uintr, userId);

            a.Add(uintr.interestID);

            return a;
        }

        private void Komunikator_Load(object sender, EventArgs e)
        {
           
        }

        /*-------------PROBY---------------*/

    /*    public void displayAdd(ImageAd img, int imgid)
        {

            using (var dbContext = new LinqClassesDataContext())
            {

                var table = from t in dbContext.ImageAds
                            where t.Id == imgid
                            select t;

                img.image = table.Single().image;

                pictureBox1.Image = ByteArrayToImage(img.image.ToArray());
            }
        }

        void proszeDzialaj(ImageAd obr)
        {
            using (var dbContext = new LinqClassesDataContext())
            {
               // var array = Enumerable.Range(1, 15).ToArray();

                List<int> array = new List<int> { 1, 2, 3, 4, 5 };

                Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        foreach (var img in array)
                        {
                            var table = from t in dbContext.ImageAds
                                        where t.Id == img
                                        select t;
                           /* var images = from t in dbContext.ImageAds
                                         where array.Contains(t.Id)
                                         select t.image;

                            //imga.image = table.Single().image;
                            // call method in ui thread
                            this.Invoke((MethodInvoker)delegate //this: form control
                            {
                                pictureBox1.Image = ByteArrayToImage(obr.image.ToArray());
                            });
                            //Thread.Sleep(1000);
                        }
                    }
                });
            }

        }

        void proba(ImageAd imga)
        {

            using (var dbContext = new LinqClassesDataContext())
            {
                var array = Enumerable.Range(1, 15).ToArray();
                //First get all image from db
                /*var images = from t in dbContext.ImageAds
                             where array.Contains(t.Id)
                             select t.image;

               // imga.image = images.Single().ToArray();

                //create thread for delay to prevent freezing screen
                Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        foreach (var img in array)
                        {
                            /*var table = from t in dbContext.ImageAds
                                        where t.Id == img
                                        select t;
                            var images = from t in dbContext.ImageAds
                                         where array.Contains(t.Id)
                                         select t.image;

                            //imga.image = table.Single().image;
                            // call method in ui thread
                            this.Invoke((MethodInvoker)delegate //this: form control
                            {
                                pictureBox1.Image = ByteArrayToImage(imga.image.ToArray());
                            });
                           // Thread.Sleep(1000);
                        }
                    }
                });
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {

            displayList(obraz);
            
        }

       


        public void displayAd(ImageAd img)
        {
            int i = 1;

            using (var dbContext = new LinqClassesDataContext())
            {
                while (true)
                {
                    var table = from t in dbContext.ImageAds
                                where t.Id == i
                                select t;

                    img.image = table.Single().image;

                    pictureBox1.Image = ByteArrayToImage(img.image.ToArray());

                   // Thread.Sleep(1000);
                    i++;

                    if (i >= 15)
                        i = 1;
                }
                
            }
        }


        public void displayList(ImageAd img)
        {
            int i = 1;
            using (var dbContext = new LinqClassesDataContext())
            {
                while(true)
                {
                    var table = from t in dbContext.ImageAds
                                where t.Id == i
                                select t;

                    img.image = table.Single().image;

                   // pictureBox1.Image = ByteArrayToImage(img.image.ToArray());

                    PictureBox pb = new PictureBox();
                    //254,15
      	            pb.Location = new Point(254, 15);
      	            pb.Size = new Size(310, 367);
      	           // pb.BorderStyle = BorderStyle.Fixed3D;
                    pb.Image = ByteArrayToImage(img.image.ToArray());
      	            pb.Cursor = System.Windows.Forms.Cursors.Hand;
      	            this.Controls.Add(pb);
      	            pb.BringToFront();

                   // Thread.Sleep(1000);
                    i++;
                    if (i >= 15)
                        i = 1;
                }
            }
        }

   

    

      
        /* public List<int> takeInterests(UserInterest uintr, int userId)
        {
            List<int> list = new List<int>();
           // UserInterest us = new UserInterest();

         
            }*/


    }
}
