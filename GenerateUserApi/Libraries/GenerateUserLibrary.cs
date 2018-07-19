using System;
using System.Collections.Generic;
using System.Linq;
using GenerateUserApi.Models;

namespace GenerateUserApi.Libraries
{
    public class GenerateUserLibrary
    {
        /*Generate for login application */
        private static Random random = new Random();

        // public string GenerateUsernameForLogin(string email)
        // {            
        //     return email;       
        // }

        // public string GenerateUsernameForTest(string email)
        // {            
        //     const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        //     return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());    
        // }

        public string GeneratePassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public User GenerateUserPass(string email)
        { 
            string Username = email;
            string Password = GeneratePassword();

            //UserModel user = new UserModel();
            //user.username = Username;
            //user.password = Password;

            return new User();
        }
    }
}