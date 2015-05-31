using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Logic
    {
        public void LoadUser(UserLogin login, string userName)
        {
            using (var dbContext = new DataClasses1DataContext())
            {
                
                    var table = from t in dbContext.User_logins
                                where t.Login == userName
                                select t;

                login.UserId = table.Single().Id;
                login.UserLogin1 = table.Single().Login;
                login.UserPassword = table.Single().Password;
                   
                

            }
        }

        public void LoadUserInfo(UserInfo info, int id)
        {
            using (var dbContext = new DataClasses1DataContext())
            {

                var table = from t in dbContext.User_infos
                            where t.Id == id
                            select t;

                info.Age = table.Single().Age;
               // info.Avatar = table.Single().Avatar;
                info.BirthDate = table.Single().Birthdate;
                info.City = table.Single().City;
                info.Interest = table.Single().Interest;
                info.Localization = table.Single().Localization;
                info.Name = table.Single().Name;
                info.Sex = table.Single().Sex;
                info.Surname = table.Single().Surname;
                info.UserId = table.Single().Id;




            }
        }

        public void AddUserInfo(UserInfo info)
        {
            User_info temp = new User_info();
            temp.Interest = info.Interest;
            temp.Age = info.Age;
            //temp.Avatar = info.Avatar;
            temp.Birthdate = info.BirthDate;
            temp.City = info.City;
            temp.Localization = info.Localization;
            temp.Name = info.Name;
            temp.Sex = info.Sex;
            temp.Surename = info.Surname;
           
            

            using (var db = new DataClasses1DataContext())
            {
                db.User_infos.InsertOnSubmit(temp);
                db.SubmitChanges();
            }
        }
    }
}
