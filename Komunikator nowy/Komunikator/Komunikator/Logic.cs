using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Komunikator
{
    class Logic
    {
        public void LoadUserInfo(User_info info, string email)
        {
            using (var dbContext = new LinqClassesDataContext())
            {

                var table = from t in dbContext.User_infos
                            where t.Email == email
                            select t;

                info.Id = table.Single().Id;
                info.Sex = table.Single().Sex;
                info.Localization = table.Single().Localization;
                info.Birthdate = table.Single().Birthdate;
                info.Name = table.Single().Name;
                info.Surname = table.Single().Surname;
                info.City = table.Single().City;
                //info.Avatar = table.Single().Avatar;
                info.Email = table.Single().Email;
                info.Password = table.Single().Password;
                info.isBusy = table.Single().isBusy;
                info.isConnected = table.Single().isConnected;

                //do rejes.
                //info.interestID = table.Single().interestID;
               




            }
        }

        public void DisplayUserInfo(User_info info, int logid)
        {
            using (var dbContext = new LinqClassesDataContext())
            {

                var table = from t in dbContext.User_infos
                            where t.Id == logid
                            select t;

                info.Id = table.Single().Id;
                info.Sex = table.Single().Sex;
                info.Localization = table.Single().Localization;
                info.Birthdate = table.Single().Birthdate;
                info.Name = table.Single().Name;
                info.Surname = table.Single().Surname;
                info.City = table.Single().City;
                //info.Avatar = table.Single().Avatar;
                info.Email = table.Single().Email;
                info.Password = table.Single().Password;
                info.isBusy = table.Single().isBusy;
                info.isConnected = table.Single().isConnected;

                //do rejes.
                //info.interestID = table.Single().interestID;





            }
        }

        public void LoadInterestId(UserInterest intr, int id)
        {
            using (var dbContext = new LinqClassesDataContext())
            {

                var table = from t in dbContext.UserInterests
                            where t.userID == id
                            select t;

                intr.Id = table.Single().Id;
                intr.interestID = table.Single().interestID;
                intr.userID = table.Single().userID;
            }
        }

        public void AddUserInfo(User_info info)
        {
            User_info temp = new User_info();

            temp.Id = info.Id;
            temp.Sex = info.Sex;
            temp.Localization = info.Localization;
            temp.Birthdate = info.Birthdate;
            temp.Name = info.Name;
            temp.Surname = info.Surname;
            temp.City = info.City;
           // temp.Avatar = info.Avatar;
            temp.Email = info.Email;
            temp.Password = info.Password;
            temp.isBusy = info.isBusy;
            temp.isConnected = info.isConnected;

            //do rejs.
            //temp.interestID = info.interestID;

            using (var db = new LinqClassesDataContext())
            {
                

                db.User_infos.InsertOnSubmit(temp);
                db.SubmitChanges();
            }
        }

       /* public void AddInterest(User_info info, List<int> interestid)
        {
            UserInterest u = new UserInterest();


            foreach (int x in interestid)
            {
                using (var dbContext = new LinqClassesDataContext())
                {

                    u.interestID = x;
                    u.userID = info.Id;

                    dbContext.UserInterests.InsertOnSubmit(u);
                    dbContext.SubmitChanges();
                }
            }

        }*/


        public void AddInterest(User_info info, int interestid)
        {
            UserInterest u = new UserInterest();


             using (var dbContext = new LinqClassesDataContext())
                {

                    u.interestID = interestid;
                    u.userID = info.Id;

                    dbContext.UserInterests.InsertOnSubmit(u);
                    dbContext.SubmitChanges();
                }
            

        }

        public void RetreiveAds(User_info info, int userid)
        {

        }


        public void RetreiveImage(ImageAd img, int imgid)
        {
            
            using (var dbContext = new LinqClassesDataContext())
            {

                var table = from t in dbContext.ImageAds
                            where t.Id == imgid
                            select t;

                img.image = table.Single().image;
            }
          
        }


        }


    }

