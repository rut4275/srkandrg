using System;
using System.Collections.Generic;

namespace FinalProject.Models‏
{
    public partial class BooksOrders
    {
        public BooksOrders()
        {
            BooksOrderItem = new HashSet<BooksOrderItem>();
        }

        public int BooksOrdersId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool AcceptLiscence { get; set; }
        public bool WithReceipt { get; set; }
        public string Note { get; set; }
        public double TotalPrice { get; set; }
        public bool Paid { get; set; }
        public bool Supplied { get; set; }

        public virtual BooksCustomers Customer { get; set; }
        public virtual ICollection<BooksOrderItem> BooksOrderItem { get; set; }
    }
}
