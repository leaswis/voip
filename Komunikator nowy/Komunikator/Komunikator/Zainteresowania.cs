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
    public partial class Zainteresowania : Form
    {
        Logic logic = new Logic();

        public Zainteresowania()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                User_info info = new User_info();

                if (checkBoxAnimals.Checked)
                {
                    info.interestID = 4;
                    
                }
                else if(checkBoxBlogs.Checked)
                {
                    info.interestID = 8;
                }
                 else if(checkBoxCuisine.Checked)
                {
                    info.interestID = 2;
                }
                 else if(checkBoxEntertaiment.Checked)
                {
                    info.interestID = 5;
                }
                 else if(checkBoxFashion.Checked)
                {
                    info.interestID = 3;
                }
                 else if(checkBoxGames.Checked)
                {
                    info.interestID = 7;
                }
                 else if(checkBoxMovies.Checked)
                {
                    info.interestID = 12;
                }
                 else if(checkBoxMusic.Checked)
                {
                    info.interestID = 10;
                }
                 else if(checkBoxRecreation.Checked)
                {
                    info.interestID = 14;
                }
                 else if(checkBoxSport.Checked)
                {
                    info.interestID = 1;
                }
                 else if(checkBoxTechnology.Checked)
                {
                    info.interestID = 6;
                }
                 else if(checkBoxTheatre.Checked)
                {
                    info.interestID = 13;
                }
                 else if(checkBoxTravels.Checked)
                {
                    info.interestID = 15;
                }
                else if (checkBoxTV.Checked)
                {
                    info.interestID = 11;
                }
                else
                {
                    MessageBox.Show("Zaznacz CO NAJMNIEJ jedno");
                }

                logic.AddUserInfo(info);
            }
            catch (Exception exc)
            {
                throw exc;
            }

             MessageBox.Show("zarejestrowano pomyślnie");
        }
    }
}
