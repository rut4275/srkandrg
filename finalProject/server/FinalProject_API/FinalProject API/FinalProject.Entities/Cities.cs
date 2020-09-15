using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class Cities
    {
        public Cities()
        {
            GuidanceGroups = new HashSet<GuidanceGroups>();
            MovieAdvertising = new HashSet<MovieAdvertising>();
            MovieOpen = new HashSet<MovieOpen>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        [JsonIgnore]
        public virtual ICollection<GuidanceGroups> GuidanceGroups { get; set; }
        public virtual ICollection<MovieAdvertising> MovieAdvertising { get; set; }
        public virtual ICollection<MovieOpen> MovieOpen { get; set; }
    }
}
