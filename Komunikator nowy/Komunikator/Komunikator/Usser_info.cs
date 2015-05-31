using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikator
{
    class Usser_info
    {
        int userID;
        int interestID;
        string Sex;
        string Localization;
        // ????
        //string Birthdate;
        // ????
        string Name;
        string Surname;
        string City;
        // ????
        //Image Avatar = new Image();
        // ????
        string Email;
        string Password;
        bool isBusy;
        bool isConnected;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        //na próbę
        public int interestid
        {
            get { return interestID; }
            set { interestID = value; }
        }

        public string sex
        {
            get { return Sex; }
            set { Sex = value; }
        }

        public string localization
        {
            get { return Localization; }
            set { Localization = value; }
        }


        /*public string birthdate
        {
            get { return Birthdate; }
            set { Birthdate = value; }
        }*/

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }


        public string surname
        {
            get { return Surname; }
            set {Surname = value; }
        }

        public string city
        {
            get { return City; }
            set { City = value; }
        }
        
       /* public Image avatar
         {
            get { return Avatar; }
            set { Avatar = value; }
        }*/

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string password
         {
            get { return Password; }
            set { Password = value; }
        }

        public bool isbusy
        {
            get { return isBusy; }
            set {isBusy  = value; }
        }

        public bool isconnected
         {
            get { return isConnected; }
            set { isConnected = value; }
        }
    }
}
