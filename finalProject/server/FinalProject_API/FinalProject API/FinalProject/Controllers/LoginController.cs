using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.BL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IUsersBl usersBl;

        public LoginController(IUsersBl _usersBl)
        {
            usersBl = _usersBl;
        }
        
        // GET: api/<LoginController>
        [HttpGet]
        public async Task<Users> Get([FromQuery] string name, [FromQuery] int password)
        {
                return await usersBl.getUser(name, password);
        }

        //// GET api/<LoginController>/5
        //[HttpGet("{id}")]
        //public string Get(string name ,int password)
        //{
        //    return "value";
        //}

        // POST api/<LoginController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
