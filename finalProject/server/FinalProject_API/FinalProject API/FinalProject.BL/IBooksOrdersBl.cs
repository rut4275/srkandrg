using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public interface IBooksOrdersBl
    {
        public Task<List<BooksOrders>> GetOrders();
        Task<bool> PutOrders(BooksOrders booksOrders);
        Task CreateNewOrder(BooksOrders booksOrders);
    }
}