using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using Newtonsoft.Json;

namespace Login.Controllers
{
    public class ShowEmployeeController : Controller
    {
        static HttpClient client = new HttpClient();

        public IActionResult ShowEmployee()
        {
            
            return View();
        }

        public string getTest(){
            return "test";
        }
       
       public static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public static async Task<UserModel> GetUserAsync()
        {
            UserModel user = null;
            HttpResponseMessage response = await client.GetAsync("api/generateuser");
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<UserModel>();
                
            }
            return user;
        }
    }
}