using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class Books
    {
        public Books()
        {
            BooksCost = new HashSet<BooksCost>();
            BooksOrderItem = new HashSet<BooksOrderItem>();
        }

        public int BookId { get; set; }
        public string NameBook { get; set; }
        public string ClassBook { get; set; }

        [JsonIgnore]
        public virtual ICollection<BooksCost> BooksCost { get; set; }
        [JsonIgnore]
        public virtual ICollection<BooksOrderItem> BooksOrderItem { get; set; }
    }
}
