using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class BlockIdNumber
    {
        public int Id { get; set; }
        public decimal? IdNumber { get; set; }
        public int? UserNum { get; set; }
        public DateTime? DateIn { get; set; }
        public string IpAddress { get; set; }
        public string ReasonExplain { get; set; }
        public decimal DataInsertAdminId { get; set; }
        public byte? PurchasesStatus { get; set; }

        public virtual Users UserNumNavigation { get; set; }
    }
}
