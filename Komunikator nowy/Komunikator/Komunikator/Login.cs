using System;
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
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
             User_info temp = new User_info();
                temp.Email = this.textBoxEmail2.Text;
                temp.Password = this.textBoxHaslo.Text;

                User_info userLogin = new User_info();
                logic.LoadUserInfo(userLogin, temp.Email);
                if (userLogin.Password == temp.Password)
                {
                    int userLogged = userLogin.Id;
                    Komunikator okno = new Komunikator(userLogged);
                    okno.Show();
                    this.Hide();
                  
                }
           
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void GoogleButton_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
