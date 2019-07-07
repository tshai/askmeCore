using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Ccdata
    {
        public string Ccnumber { get; set; }
        public int? UserId { get; set; }
        public DateTime DateIn { get; set; }
        public byte Status { get; set; }
        public int Id { get; set; }
        public int SuspiciousAmount { get; set; }
        public string ReasonExplain { get; set; }
        public int? DataInsertAdminId { get; set; }
        public string IpAddress { get; set; }
        public decimal? IdNumber { get; set; }
        public string EncryptCard { get; set; }

        public virtual Users User { get; set; }
    }
}
