﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Rejestracja : Form
    {
        Logic logic = new Logic();
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfo info = new UserInfo();
            info.City = this.textBoxMiasto.Text;
            info.Name = this.textBoxImie.Text;
            info.Surname = this.textBoxNazwisko.Text;
            //info.Email = this.textBoxEmail.Text;
            if (radioButtonKobieta.Checked)
            {
                info.Sex = this.radioButtonKobieta.Text;
            }
            else { info.Sex = this.radioButtonMezczyzna.Text; }
            //info.Age = this.textBoxWiek.Text; ----!!! zmienić na string

            UserLogin login = new UserLogin();
            login.UserLogin1 = this.textBoxLogin.Text;
            login.UserPassword = this.textBoxHaslo.Text;

            logic.AddUserInfo(info);
            //logic.AddUserInfo(login);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }
    }
}
