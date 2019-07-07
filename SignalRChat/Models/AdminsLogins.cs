using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class AdminsLogins
    {
        public int AdminId { get; set; }
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }

        public virtual Admins Admin { get; set; }
    }
}
