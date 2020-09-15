using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class MovieClose
    {
        public int MovieId { get; set; }
        public int OrderId { get; set; }
        public int ContactId { get; set; }
        public double TotalAmount { get; set; }
        public bool WithReceipt { get; set; }
        public int PaymentId { get; set; }
        public string MovieAddress { get; set; }
        public DateTime MovieDate { get; set; }
        public int InChargeId { get; set; }
        public double InChargeAmount { get; set; }
        public bool GlobalMovie { get; set; }
        public double? PricePerHead { get; set; }
        public int? TotalParticipants { get; set; }
        public bool Paid { get; set; }
        public int FilmId { get; set; }
        public int PeriodId { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual Films Film { get; set; }
        public virtual Contacts InCharge { get; set; }
        public virtual Contacts Order { get; set; }
        public virtual MoviePayment Payment { get; set; }
        [JsonIgnore]
        public virtual MoviePeriod Period { get; set; }
    }
}
