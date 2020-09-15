using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class MoviePayment
    {
        public MoviePayment()
        {
            MovieClose = new HashSet<MovieClose>();
        }

        public int PaymentId { get; set; }
        public string PaymentType { get; set; }

        [JsonIgnore]
        public virtual ICollection<MovieClose> MovieClose { get; set; }
    }
}
