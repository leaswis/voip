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
        UserInterest userint = new UserInterest();
        Interest intr = new Interest();

        public Profil(int dataReceived)
        {
            InitializeComponent();

            loggedUser = dataReceived;

            logic.DisplayUserInfo(user_info, loggedUser);
            textBoxCity.Text = user_info.City;
            textBoxEmail.Text = user_info.Email;
            textBoxName.Text = user_info.Name;
            textBoxSurname.Text = user_info.Surname;
            textBoxSex.Text = user_info.Sex;

            int[] list = takeListInterest(userint, loggedUser);
            List<string> nazwy = new List<string>();

            

            foreach (int i in list)
            {
                logic.LoadInterests(intr, i);
                nazwy.Add(intr.Interest1);
               
            }

            textBoxInterests.Text = string.Join(", ", nazwy);

        }

        public int[] takeListInterest(UserInterest usr, int userId)
        {

            using (var dbContext = new LinqClassesDataContext())
            {

                int[] list_interest = dbContext.UserInterests
                .Where(v => v.userID == userId)
                .Select(v => v.interestID).ToArray();

                return list_interest;

            }

        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }
    }
}
