using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class BooksOrdersDl : IBooksOrdersDl
    {
        public FinalProjectContext context;
        public BooksOrdersDl(FinalProjectContext _context)
        {
            context = _context;
        }

        public async Task CreateNewOrder(BooksOrders booksOrders)
        {
            await context.BooksOrders.AddAsync(booksOrders);
            await context.SaveChangesAsync();
        }

        public async Task<List<BooksOrders>> GetOrders()
        {
            var books = await context.BooksOrders
                .Include(e => e.Customer)
                .ThenInclude(e => e.CustomerCategory)
                .Include(e => e.Customer.Contact)
                .Include(e => e.BooksOrderItem)
                .ThenInclude(e => e.Book)
                .ToListAsync();
            return books;
        }

        public async Task<bool> PutOrders(BooksOrders booksOrders)
        {
            await context.BooksOrders.ForEachAsync(b =>
              {
                  if (b.BooksOrdersId == booksOrders.BooksOrdersId)
                  {
                      b.AcceptLiscence = booksOrders.AcceptLiscence;
                      b.BooksOrderItem = booksOrders.BooksOrderItem;
                      b.Customer = booksOrders.Customer;
                      b.CustomerId = booksOrders.CustomerId;
                      b.Note = booksOrders.Note;
                      b.OrderDate = booksOrders.OrderDate;
                      b.Paid = booksOrders.Paid;
                      b.Supplied = booksOrders.Supplied;
                      b.TotalPrice = booksOrders.TotalPrice;
                      b.WithReceipt = booksOrders.WithReceipt;
                  };
              });
            await context.SaveChangesAsync();
            return false;
        }
    }
}

