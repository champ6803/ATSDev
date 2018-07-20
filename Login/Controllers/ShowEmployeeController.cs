using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class ShowEmployeeController : Controller
    {
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
        }

        public async Task<List<UserModel>> GetAsync(CancellationToken cancellationToken)
        {
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
        }
    }
}