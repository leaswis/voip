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


namespace Komunikator
{
    public partial class Komunikator : Form
    {
        ImageAd obraz = new ImageAd();
        Logic logic = new Logic();

        //List<Image> list = new List<Image>();

        public Komunikator(int dataReceived)
        {
            User_info info = new User_info();
            InitializeComponent();

            int loggedUser = dataReceived;

         displayAdds(obraz, 8);

        logic.DisplayUserInfo(info, loggedUser);
        string name = info.Name;
        label2.Text = name;
         

         
            
        }

        public void displayAdds(ImageAd img, int imgid)
        {
           //logic.RetreiveImage(obraz, 4);


           // pictureBox1.Image = ByteArrayToImage

            using (var dbContext = new LinqClassesDataContext())
            {

                var table = from t in dbContext.ImageAds
                            where t.Id == imgid
                            select t;

                img.image = table.Single().image;

                pictureBox1.Image = ByteArrayToImage(img.image.ToArray());
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

    }
}
