using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UserChangeStatus
    {
        public int? SupplierId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? DateIn { get; set; }
        public int GirlChangeStatusId { get; set; }
        public int? NewStatus { get; set; }
        public int? LastStatus { get; set; }
        public int? Qtype { get; set; }
        public int? GirlNotActiveTime { get; set; }
        public int? UserFatal { get; set; }
        public Guid? GirlRndNum { get; set; }
        public int? UserNotActiveTime { get; set; }
        public string SpName { get; set; }
    }
}
