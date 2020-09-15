using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class MovieAdvertisingStage
    {
        public MovieAdvertisingStage()
        {
            MovieAdvertising = new HashSet<MovieAdvertising>();
        }

        public int AdvertisingStageId { get; set; }
        public string AdvertisingStageName { get; set; }
        public string AdvertisingStageEmail { get; set; }

        [JsonIgnore]
        public virtual ICollection<MovieAdvertising> MovieAdvertising { get; set; }
    }
}
