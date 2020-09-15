using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class BooksCost
    {
        public int CostId { get; set; }
        public int BookId { get; set; }
        public int CustomerCategoryId { get; set; }
        public int Year { get; set; }
        public int Cost { get; set; }

        public virtual Books Book { get; set; }
        [JsonIgnore]
        public virtual BooksCustomersCategories CustomerCategory { get; set; }
    }
}
