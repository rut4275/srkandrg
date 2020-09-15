using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailService;
using FinalProject.BL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IBooksOrdersBl booksOrdersBl;
        //private IEmailSender emailSender;, IEmailSender _emailSenderemailSender = _emailSender;
        public BooksController(IBooksOrdersBl _booksOrdersBl)
        {
            booksOrdersBl = _booksOrdersBl;
            
        }
        // GET: api/<BooksController>
        [HttpGet]
        public async Task<List<BooksOrders> >Get()
        {
            return await booksOrdersBl.GetOrders();
        }

        //// GET api/<BooksController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<BooksController>
        [HttpPost]
        public async Task Post([FromBody] BooksOrders booksOrders)
        {
            await booksOrdersBl.CreateNewOrder(booksOrders);
        }

        // PUT api/<BooksController>/5
        //[HttpPut("{id}")]
        public async Task Put([FromBody] BooksOrders booksOrders)
        {
            await booksOrdersBl.PutOrders(booksOrders);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
