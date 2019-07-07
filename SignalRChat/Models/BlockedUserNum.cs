using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class BlockedUserNum
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? Status { get; set; }
        public DateTime? DateIn { get; set; }
        public decimal? IdNumber { get; set; }
        public string IpAddress { get; set; }
        public string ReasonExplain { get; set; }
        public int? DataInsertAdminId { get; set; }
        public int? PurchasesStatus { get; set; }

        public virtual Users User { get; set; }
    }
}
