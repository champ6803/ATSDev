using System;
using System.Collections.Generic;
using System.Linq;
using GenerateUserApi.Models;

namespace GenerateUserApi.Libraries
{
    public class GenerateUserLibrary
    {
        private static Random random = new Random();

        public string GenerateUsername(string email)
        {            
            return email;       
        }

        public string GeneratePassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public UserModel GenerateUserPass(string email)
        {
            string Username = GenerateUsername(email);
            string Password = GeneratePassword();

            UserModel user = new UserModel();
            user.username = Username;
            user.password = Password;

            return user;
        }
    }
}