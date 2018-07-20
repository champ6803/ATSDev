using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class ShowEmployeeController : Controller
    {
        public IActionResult ShowEmployee()
        {
            return View();
        }
         public ActionResult Index(string e) 
        {
            
            // WebClient client = new WebClient();
            // string url = dashboardUrlBase + "GetUserRecord?userName=" + adSAMName;
            // User result = JsonConvert.DeserializeObject<User>(client.DownloadString(url));
            return View();
        }
    }
}