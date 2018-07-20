using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerateUserApi.Models;

namespace GenerateUserApi.Libraries
{
    public class GenerateUserLibrary
    {
        ProfileDAL prodDal = new ProfileDAL();
        UserDAL userDal = new UserDAL();

        public async Task<IEnumerable<Profile>> GetAll()
        {
            var all = await prodDal.All();
            return all;
        }
        /*Generate for login application */
        private static Random random = new Random();

        public string GenerateUserFOrExam()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5).Select(s =>
             s[random.Next(s.Length)]).ToArray());
        }

        public string GeneratePassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 16).Select(s =>
             s[random.Next(s.Length)]).ToArray());
        }

        public async Task<Profile> GenerateUserPass(string email)
        {
            var getProf = await prodDal.GetProfile(email);

            Profile p = new Profile();
            User u = new User();

            string Username;
            string Password;
            if (getProf != null)
            {
                if (getProf.typeAccount == "Application")
                {
                    Username = email;
                    Password = GeneratePassword();

                    u.user = Username;
                    u.pwd = Password;
                }
                else if (getProf.typeAccount == "Exam")
                {
                    Username = GenerateUserFOrExam();
                    Password = GeneratePassword();

                    u.user = Username;
                    u.pwd = Password;
                }

                u.email = email;                
                u.typeAccount = getProf.typeAccount;
                var user = userDal.InsertUser(u);

                p.id = getProf.id;
                p.name = getProf.name;
                p.email = email;
                p.typeAccount = getProf.typeAccount;
            }
            return p;
        }
    }
}