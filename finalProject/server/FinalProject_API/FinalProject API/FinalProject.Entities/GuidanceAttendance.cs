using System;
using System.Collections.Generic;

namespace FinalProject.Models‏
{
    public partial class GuidanceAttendance
    {
        public int MeetingId { get; set; }
        public int RegistrantId { get; set; }
        public bool Attendance { get; set; }

        public virtual GuidanceMeetings Meeting { get; set; }
        public virtual GuidanceRegistrants Registrant { get; set; }
    }
}
