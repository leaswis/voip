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
    public partial class Profil : Form
    {
        Logic logic = new Logic();
        User_info user_info = new User_info();
        int loggedUser;

        public Profil(int dataReceived)
        {
            InitializeComponent();

            loggedUser = dataReceived;

            logic.DisplayUserInfo(user_info, loggedUser);
            textBoxCity.Text = user_info.City;
            textBoxEmail.Text = user_info.Email;
            textBoxName.Text = user_info.Name;
            textBoxSurname.Text = user_info.Surname;
        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }
    }
}
