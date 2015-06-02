﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunikator
{
    public partial class Login : Form
    {
        Logic logic = new Logic();
        public Login()
        {
            InitializeComponent();

            textBoxHaslo.PasswordChar = '*';
            textBoxHaslo.MaxLength = 30;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Rejestracja okno = new Rejestracja();
            okno.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Komunikator okno = new Komunikator();
            try
            {
                User_info temp = new User_info();
                temp.Email = this.textBoxEmail2.Text;
                temp.Password = this.textBoxHaslo.Text;

                User_info userLogin = new User_info();
                logic.LoadUserInfo(userLogin, temp.Email);
                if (userLogin.Password == temp.Password)
                {
                    okno.Show();
                   // MessageBox.Show("Zalogowano");
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }

            /*Komunikator okno = new Komunikator();
            okno.Show();*/
        }
    }
}
