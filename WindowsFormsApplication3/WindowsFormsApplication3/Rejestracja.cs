using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       // private Bitmap avatar;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.bmp|*.jpg|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAvatar.ImageLocation = ofd.FileName;
                //pictureBoxAvatar.Image = Bitmap.FromFile(ofd.FileName);
            }


        }
    }
}
