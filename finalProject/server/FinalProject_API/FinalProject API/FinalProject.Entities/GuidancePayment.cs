using System;
using System.Collections.Generic;

namespace FinalProject.Models‏
{
    public partial class GuidancePayment
    {
        public GuidancePayment()
        {
            GuidanceRegistrants = new HashSet<GuidanceRegistrants>();
        }

        public int PaymentId { get; set; }
        public string PaymentType { get; set; }

        public virtual ICollection<GuidanceRegistrants> GuidanceRegistrants { get; set; }
    }
}
