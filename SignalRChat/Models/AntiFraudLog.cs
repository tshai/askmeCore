using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class AntiFraudLog
    {
        public int Id { get; set; }
        public DateTime? DateIn { get; set; }
        public int? UserId { get; set; }
        public string Reason { get; set; }
        public string Ccnumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Cvv { get; set; }
        public byte Active { get; set; }
        public string IdNumber { get; set; }
        public string LastDigits { get; set; }
        public string Treatment { get; set; }
        public string IpAddress { get; set; }
        public string Country { get; set; }
        public byte? Priority { get; set; }
        public string Cccountry { get; set; }
        public int CcDetailsId { get; set; }

        public virtual Users User { get; set; }
    }
}
