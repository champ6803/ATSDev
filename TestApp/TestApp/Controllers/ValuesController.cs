﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using MongoDB.Bson;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        DataAccess objds = new DataAccess();

        //public ValuesController()
        //{
        //    objds = d;
        //}

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            DataAccess cs = new DataAccess();
            return await cs.All();
        }

        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            DataAccess cs = new DataAccess();
            return await cs.Get(id);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
