using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class TestGenerateUserController : Controller
    {
        public IActionResult TestGenerateUser()
        {
            return View();
        }
    }
}