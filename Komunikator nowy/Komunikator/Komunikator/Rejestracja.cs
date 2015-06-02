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
            try
            {
               


                info.Name = this.textBoxName.Text;
                info.Surname = this.textBoxSurname.Text;
                info.City = this.textBoxCity.Text;
                info.Email = this.textBoxEmail.Text;
                info.Password = this.textBoxPassword.Text;
                info.isBusy = false;
                info.isConnected = false;
                if (radioButtonFemale.Checked)
                {
                    info.Sex = this.radioButtonFemale.Text;
                }
                else if (radioButtonMale.Checked)
                {
                    info.Sex = this.radioButtonMale.Text;
                }
                /*else
                {
                    info.Sex = "inny";
                }*/
             
                logic.AddUserInfo(info);
           /* }
            catch(Exception exc)
            {
                throw exc;
            }

             try
             {*/

                 List<int> list = new List<int>();

                 logic.LoadUserInfo(info, info.Email);
           
                if (checkBoxAnimals.Checked)
                {
                    //info.interestID = 4;

                   // list.Add(4);

                    logic.AddInterest(info, 4);

                }
                if (checkBoxBlogs.Checked)
                {
                    

                    //list.Add(8);

                    logic.AddInterest(info, 8);


                }
                if (checkBoxCuisine.Checked)
                {
                    

                   // list.Add(2);
                    logic.AddInterest(info, 2);
                }
                if (checkBoxEntertaiment.Checked)
                {
                    

                    //list.Add(5);

                    logic.AddInterest(info, 5);

                }
                if (checkBoxFashion.Checked)
                {
                    

                    //list.Add(3);

                    logic.AddInterest(info, 3);
                }
                if (checkBoxGames.Checked)
                {
                   

                   // list.Add(7);
                    logic.AddInterest(info, 7);
                }
               if (checkBoxMovies.Checked)
                {
                    // info.interestID = 12;

                    list.Add(12);
                }
                if (checkBoxMusic.Checked)
                {
                   

                    //list.Add(10);

                    logic.AddInterest(info, 10);
                }
                if (checkBoxRecreation.Checked)
                {

                   

                    //list.Add(14);

                    logic.AddInterest(info, 14);
                }
                if (checkBoxSport.Checked)
                {
                    

                    //list.Add(1);

                    logic.AddInterest(info, 1);
                }
               if (checkBoxTechnology.Checked)
                {
                    

                    //list.Add(6);

                    logic.AddInterest(info, 6);
                }
                if (checkBoxTheatre.Checked)
                {
                    

                   // list.Add(13);

                    logic.AddInterest(info, 13);
                }
                if (checkBoxTravels.Checked)
                {
                   

                    //list.Add(15);

                    logic.AddInterest(info, 15);
                }
                if (checkBoxTV.Checked)
                {
                    
                    //list.Add(11);

                    logic.AddInterest(info, 11);
                }
               /* if (zadne nie jest zaznaczone)
                {
                    MessageBox.Show("Zaznacz CO NAJMNIEJ jedno");
                }*/

                

                 //logic.AddInterest(info, list);
                
            }
            catch (Exception exc)
            {
                throw exc;
            }

            MessageBox.Show("zarejestrowano pomyślnie");


        }
    }
}
