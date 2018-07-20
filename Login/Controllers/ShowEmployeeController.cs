using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using Newtonsoft.Json;
=======
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623

namespace Login.Controllers
{
    public class ShowEmployeeController : Controller
    {
<<<<<<< HEAD
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

=======
        HttpClient client = new HttpClient();
        public IActionResult ShowEmployee()
        {
            //var test = GetAsync(CancellationToken.None);
            return View();
        }
        public ShowEmployeeController()
        {
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
        }

        public static async Task<UserModel> GetUserAsync()
        {
<<<<<<< HEAD
            UserModel user = null;
            HttpResponseMessage response = await client.GetAsync("api/generateuser");
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<UserModel>();
                
            }
            return user;
=======
            await Task.Delay(3000);
            //ancellationToken.ThrowIfCancellationRequested();

            HttpResponseMessage response = await client.GetAsync("api/generateUser", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<UserModel>>(result);
            }
            return new List<UserModel>();
            //return null;
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
        }
    }
}