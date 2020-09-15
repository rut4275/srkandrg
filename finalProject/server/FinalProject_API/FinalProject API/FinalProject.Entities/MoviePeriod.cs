using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class MoviePeriod
    {
        public MoviePeriod()
        {
            MovieAdvertising = new HashSet<MovieAdvertising>();
            MovieClose = new HashSet<MovieClose>();
            MovieOpen = new HashSet<MovieOpen>();
        }

        public int PeriodId { get; set; }
        public string PeriodName { get; set; }
        public DateTime? PeriodDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<MovieAdvertising> MovieAdvertising { get; set; }
        public virtual ICollection<MovieClose> MovieClose { get; set; }
        public virtual ICollection<MovieOpen> MovieOpen { get; set; }
    }
}
