using System;
using System.Collections.Generic;

namespace FinalProject.Models‏
{
    public partial class MovieOpen
    {
        public int MovieId { get; set; }
        public int CityId { get; set; }
        public string CityAddress { get; set; }
        public int PeriodId { get; set; }
        public DateTime MovieDate { get; set; }
        public int ContactCultureId { get; set; }
        public int NumberOfSeatsAuditorium { get; set; }
        public bool WithEquipment { get; set; }
        public double EquipmentCost { get; set; }
        public double AuditoriumCost { get; set; }
        public int FilmId { get; set; }
        public int CountParticipantsAfternoon { get; set; }
        public int CountParticipantsEvening { get; set; }
        public double TicketCostAfternoon { get; set; }
        public double TicketCostEvening { get; set; }
        public int InChargeId { get; set; }
        public double InChargeAmount { get; set; }
        public bool InChargePaid { get; set; }
        public double NetProfitForDay { get; set; }

        public virtual Cities City { get; set; }
        public virtual Contacts ContactCulture { get; set; }
        public virtual Films Film { get; set; }
        public virtual Contacts InCharge { get; set; }
        public virtual MoviePeriod Period { get; set; }
    }
}
