using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoginWeb.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            //iewData["Message"] = "Form";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
