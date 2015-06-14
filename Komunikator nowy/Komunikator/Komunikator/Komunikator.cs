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

  

        private void Komunikator_Load(object sender, EventArgs e)
        {
           
        }

      

        private void voipButton_Click(object sender, EventArgs e)
        {
            Voip okno = new Voip(loggedUser);
            okno.Show();
        }


    }
}
