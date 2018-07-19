using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GenerateUserApi.Helper;
using GenerateUserApi.Models;

namespace GenerateUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateUserController : ControllerBase
    {
        protected GenerateUserHelper genHelp = new GenerateUserHelper();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /*Generate for login application */
        // GET api/GenerateUser/jida@gmail.com
        [HttpGet("{user}")]
        public UserModel Get(string user)
        {
            var genUser = genHelp.GenerateUser(user);
            return genUser; 
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
