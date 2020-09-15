using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class BooksCustomersCategories
    {
        public BooksCustomersCategories()
        {
            BooksCost = new HashSet<BooksCost>();
            BooksCustomers = new HashSet<BooksCustomers>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<BooksCost> BooksCost { get; set; }
        [JsonIgnore]
        public virtual ICollection<BooksCustomers> BooksCustomers { get; set; }
    }
}
