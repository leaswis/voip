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
using MySql.Data.Types;
using MySql.Data.Common;
using System.Net;
using System.IO;
using System.Web;

using Facebook;

namespace WindowsFormsApplication3
{
    public partial class Login : Form

    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            /* Glowny okno = new Glowny();
             okno.Show();
             this.Hide();*/

            try
            {
                string myConnection = "server=localhost;port=3306;username=root;password=lolek123";
                MySqlConnection myCon = new MySqlConnection(myConnection);
                //MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlCommand Select = new MySqlCommand("select * from komunikator.user_login where Login= '" + this.textBoxLogin.Text + "' and Password= '" + this.textBoxHaslo.Text + "' ;", myCon);

                MySqlDataReader myReader;
                myCon.Open();
                myReader = Select.ExecuteReader();
                int count = 0;
                while(myReader.Read())
                {
                    count = count + 1;

                }
                if (count == 1)
                {
                    MessageBox.Show("Zalogowano pomyślnie");
                    
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło.");
                }
                myCon.Close();

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
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
