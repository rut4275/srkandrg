using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class BooksCustomers
    {
        public BooksCustomers()
        {
            BooksOrders = new HashSet<BooksOrders>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerCategoryId { get; set; }
        public int ContactId { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual BooksCustomersCategories CustomerCategory { get; set; }
        [JsonIgnore]
        public virtual ICollection<BooksOrders> BooksOrders { get; set; }
    }
}
