using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class BooksOrderItem
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public virtual Books Book { get; set; }
        [JsonIgnore]
        public virtual BooksOrders Order { get; set; }
    }
}
