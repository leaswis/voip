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
                int count = dbContext.User_logins.Count();
                
                    var table = from t in dbContext.User_logins
                                where t.Login == userName
                                select t;

                login.UserId = table.Single().Id;
                login.UserLogin1 = table.Single().Login;
                login.UserPassword = table.Single().Password;
                   
                

            }
        }
    }
}
