using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Komunikator : Form
    {
        public Komunikator()
        {
            InitializeComponent();
            Login okno1 = new Login();
            okno1.Show();

            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Profil okno = new Profil();
            okno.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void userArchive_Click(object sender, EventArgs e)
        {

        }

        private void Komunikator_Load(object sender, EventArgs e)
        {

        }
    }
}
