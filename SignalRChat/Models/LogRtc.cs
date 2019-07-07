using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class LogRtc
    {
        public int Id { get; set; }
        public int ChatTimeUseId { get; set; }
        public DateTime DateIn { get; set; }
        public string SupplierId { get; set; }
        public string CustomerId { get; set; }
    }
}
