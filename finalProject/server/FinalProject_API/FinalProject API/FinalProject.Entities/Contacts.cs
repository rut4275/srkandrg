using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class Contacts
    {
        public Contacts()
        {
            BooksCustomers = new HashSet<BooksCustomers>();
            GuidanceRegistrants = new HashSet<GuidanceRegistrants>();
            MovieAdvertising = new HashSet<MovieAdvertising>();
            MovieCloseContact = new HashSet<MovieClose>();
            MovieCloseInCharge = new HashSet<MovieClose>();
            MovieCloseOrder = new HashSet<MovieClose>();
            MovieOpenContactCulture = new HashSet<MovieOpen>();
            MovieOpenInCharge = new HashSet<MovieOpen>();
        }

        public int ContactId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }

        [JsonIgnore]
        public virtual ICollection<BooksCustomers> BooksCustomers { get; set; }
        public virtual ICollection<GuidanceRegistrants> GuidanceRegistrants { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieAdvertising> MovieAdvertising { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieClose> MovieCloseContact { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieClose> MovieCloseInCharge { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieClose> MovieCloseOrder { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieOpen> MovieOpenContactCulture { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieOpen> MovieOpenInCharge { get; set; }
    }
}
