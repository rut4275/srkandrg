using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public interface IBooksOrdersDl
    {
        public Task<List<BooksOrders>> GetOrders();
        Task<bool> PutOrders(BooksOrders booksOrders);
        Task CreateNewOrder(BooksOrders booksOrders);
    }
}