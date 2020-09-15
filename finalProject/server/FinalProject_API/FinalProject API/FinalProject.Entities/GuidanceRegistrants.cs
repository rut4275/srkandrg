using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class GuidanceRegistrants
    {
        public int RegistrantId { get; set; }
        public int ContactId { get; set; }
        public int GroupId { get; set; }
        public int PaymentId { get; set; }
        public bool Paid { get; set; }

        [JsonIgnore]
        public virtual Contacts Contact { get; set; }
        public virtual GuidanceGroups Group { get; set; }
        public virtual GuidancePayment Payment { get; set; }
    }
}
