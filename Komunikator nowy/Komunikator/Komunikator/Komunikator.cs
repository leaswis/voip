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
using System.Diagnostics;
//using System.Threading;



namespace Komunikator
{
    public partial class Komunikator : Form
    {
        ImageAd obraz = new ImageAd();
        UserInterest user_interest = new UserInterest();
        int loggedUser;
 
      Logic logic = new Logic();
      DateTime today = DateTime.Today;
        //List<Image> list = new List<Image>();

        public Komunikator(int dataReceived)
        {
            User_info info = new User_info();
            InitializeComponent();

            loggedUser = dataReceived;

            logic.DisplayUserInfo(info, loggedUser);
            string name = info.Name;
            labelHello.Text = "Witaj " + name + "!";

            DateTime? bt = info.Birthdate;
            if (bt != null)
            {
                DateTime bd = bt.Value;
                int bdate = today.Year - bd.Year;
                List<int> ageid = ageId(bdate);

                displayAddsOnAge(obraz, ageid);
            }
            
            
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

        private async void displayAddsOnAge(ImageAd img, List<int> list)
        {
          

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

                        pictureBox2.Image = ByteArrayToImage(img.image.ToArray());
                        pictureBox2.Refresh();
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


        public List<int> ageId(int age)
        {
            List<int> a = new List<int>();// { 18, 19, 20 };
           if (age <= 30 && age >= 20)
               { a.Add(18);
               a.Add(19);
               a.Add(20);
           }

           if (age <= 40 && age > 30)
           {
               a.Add(21);
               a.Add(22);
               a.Add(23);
           }

            return a;   
        }
  

        private void Komunikator_Load(object sender, EventArgs e)
        {
           
        }

      

        private void voipButton_Click(object sender, EventArgs e)
        {
            Rozmowa okno = new Rozmowa(loggedUser);
            okno.Show();
        }
        
        private void myProfileButton_Click(object sender, EventArgs e)
        {
            Profil okno = new Profil(loggedUser);
            okno.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.pudelek.pl");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.pl");
        }


    }
}
