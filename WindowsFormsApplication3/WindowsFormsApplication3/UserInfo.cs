using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class UserInfo
    {
        int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        int? age;

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }
        string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

       /* string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }*/

        string localization;

        public string Localization
        {
            get { return localization; }
            set { localization = value; }
        }
        string interest;

        public string Interest
        {
            get { return interest; }
            set { interest = value; }
        }
        DateTime? birthDate;

        public DateTime? BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
       /* Image? avatar;

        public Image? Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }*/
    }
}
