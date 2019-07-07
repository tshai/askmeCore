using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class BlockIp
    {
        public string IpAddress { get; set; }
        public DateTime? DateIn { get; set; }
        public int Id { get; set; }
        public byte BlockType { get; set; }
        public int? UserId { get; set; }
        public decimal? IdNumber { get; set; }
        public int? PurchasesStatus { get; set; }
        public string ReasonExplain { get; set; }
        public int? DataInsertAdminId { get; set; }
        public int? DaysToBlock { get; set; }
        public int EmployeeId { get; set; }
        public string CcNumber { get; set; }
        public int BlockStatus { get; set; }
        public string RemoveFromBlockReason { get; set; }

        public virtual Users User { get; set; }
    }
}
