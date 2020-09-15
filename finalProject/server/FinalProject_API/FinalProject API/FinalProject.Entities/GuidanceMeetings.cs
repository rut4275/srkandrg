using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class GuidanceMeetings
    {
        public int MeetingId { get; set; }
        public int GroupId { get; set; }
        public int NumMeeting { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Note { get; set; }
        public int FoodCost { get; set; }

        [JsonIgnore]
        public virtual GuidanceGroups Group { get; set; }
    }
}
