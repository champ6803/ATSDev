using System;
using System.Collections.Generic;
using System.Linq;
using GenerateUserApi.Libraries;
using GenerateUserApi.Models;

namespace GenerateUserApi.Helper
{
    public class GenerateUserHelper
    {
        public User GenerateUser(string email)
        {
            return new GenerateUserLibrary().GenerateUserPass(email);
        }
    }
}