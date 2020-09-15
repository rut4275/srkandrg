using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class MovieAdvertising
    {
        public int AdvertisingId { get; set; }
        public int AdvertisingStageId { get; set; }
        public int CityId { get; set; }
        public DateTime AdvertisingDates { get; set; }
        public int PeriodId { get; set; }
        public int AdvertisingTypeId { get; set; }
        public string AdvertisingSize { get; set; }
        public double AdvertisingCost { get; set; }
        public int AdvertisingContactId { get; set; }

        public virtual Contacts AdvertisingContact { get; set; }
        public virtual MovieAdvertisingStage AdvertisingStage { get; set; }
        public virtual MovieAdvertisingType AdvertisingType { get; set; }
        [JsonIgnore]
        public virtual Cities City { get; set; }
        public virtual MoviePeriod Period { get; set; }
    }
}
