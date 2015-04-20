using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;

using Facebook;

namespace WindowsFormsApplication3
{
    public partial class Login : Form

    {
        Logic logic = new Logic();
        public Login()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
            textBoxHaslo.MaxLength = 20;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            
            UserLogin temp = new UserLogin();
            temp.UserLogin1 = this.textBoxLogin.Text;
            temp.UserPassword = this.textBoxHaslo.Text;

            UserLogin userLogin = new UserLogin();
            logic.LoadUser(userLogin, temp.UserLogin1);
            if (userLogin.UserPassword == temp.UserPassword) 
            {
                MessageBox.Show("Dobre hasło");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rejestracja okno = new Rejestracja();
            okno.Show();
        }

        private void buttonLoginFacebook_Click(object sender, EventArgs e)
        {

        }
    }
}
