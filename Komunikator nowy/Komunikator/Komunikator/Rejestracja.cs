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
    public partial class Rejestracja : Form
    {
        Logic logic = new Logic();

        public Rejestracja()
        {
            InitializeComponent();
           
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 30;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User_info info = new User_info();

            
            info.Name = this.textBoxName.Text;
            info.Surname = this.textBoxSurname.Text;
            info.City = this.textBoxCity.Text;
            info.Email = this.textBoxEmail.Text;
            info.Password = this.textBoxPassword.Text;
            if (radioButtonFemale.Checked)
            {
                info.Sex = this.radioButtonFemale.Text;
            }
            if (radioButtonMale.Checked)
            {
                info.Sex = this.radioButtonMale.Text;
            }
            else
            {
                info.Sex = this.radioButtonUndefined.Text;
            }
           
            //na próbę
            info.interestID = 1;

            //przy rejestracji aut. na false
            info.isBusy = false;
            info.isConnected = false;


            logic.AddUserInfo(info);

        }
    }
}
