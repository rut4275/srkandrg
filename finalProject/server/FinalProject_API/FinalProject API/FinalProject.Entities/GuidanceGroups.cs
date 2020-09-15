using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class GuidanceGroups
    {
        public GuidanceGroups()
        {
            GuidanceMeetings = new HashSet<GuidanceMeetings>();
            GuidanceRegistrants = new HashSet<GuidanceRegistrants>();
        }

        public int GroupId { get; set; }
        public string MeetingAddress { get; set; }
        public int MeetingCityId { get; set; }
        public int MeetingNumber { get; set; }
        public DateTime MeetingFirstDate { get; set; }
        public DateTime MeetingLastDate { get; set; }
        public int PricePerHead { get; set; }
        public bool MeetingStatus { get; set; }
        public int ParticipantsNumber { get; set; }
        public int PlaceCost { get; set; }
        public int SecrataryCost { get; set; }

        public virtual Cities MeetingCity { get; set; }
        public virtual ICollection<GuidanceMeetings> GuidanceMeetings { get; set; }
        [JsonIgnore]
        public virtual ICollection<GuidanceRegistrants> GuidanceRegistrants { get; set; }
    }
}
