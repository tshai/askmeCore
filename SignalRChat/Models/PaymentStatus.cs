using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class PaymentStatus
    {
        public int SaleId { get; set; }
        public string PriceAmount { get; set; }
        public string TruncatedPan { get; set; }
        public DateTime DateIn { get; set; }
        public string EventType { get; set; }
        public int? UserNum { get; set; }
        public string ReferenceId { get; set; }
    }
}
