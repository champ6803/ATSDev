using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerateUserApi.Models;

namespace GenerateUserApi.Libraries
{
    public class GenerateUserLibrary
    {
        ProfileDAL dal = new ProfileDAL();

        public async Task<IEnumerable<Profile>> GetAll() {
            var all =  await dal.All();
            return  all;
        }
        /*Generate for login application */
        private static Random random = new Random();

        public string GeneratePassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => 
             s[random.Next(s.Length)]).ToArray());
        }

        public async Task<Profile> GenerateUserPass(string email)
        {
            var d = await dal.GetProfile(email);

            Profile p = new Profile();
            if (d != null)
            {
                string Username = email;
                string Password = GeneratePassword();
                p.id = d.id;
                p.name = d.name;
                p.email = Username;
            }
            return p;
        }
    }
}