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
            okno.Show();
        }
    }
}
