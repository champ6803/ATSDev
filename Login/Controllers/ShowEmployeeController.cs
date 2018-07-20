using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using Login.UserModel;
using System.Net.Http;
using System.Net.HttpCilent;
using Newtonsoft.Json;


namespace Login.Controllers
{
    public class ShowEmployeeController : Controller
    {
        HttpCilent cilent = new HttpCilent();
        public IActionResult ShowEmployee()
        {
            return View();
        }
         public UserRepo() 
        {
            cilent.BaseAddress = new Url("https://localhost:5001/");
            cilent.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderVaalue("application/json")
            );
        }

        public async Task<List<UserModel>> GetAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(3000);
            cancellationToken.ThrowIfCancellationToken();

            HttpResponseMessage response = await cilent.GetAsync("api/generateUser", cancellationToken);
            if(response.IsSuccessStatusCode)
            {
                var result =  await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject <List<UserModel>>(result);
            }
                return new <List<UserModel>>();
            return null;
        }
    }
}