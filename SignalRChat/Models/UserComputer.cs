using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UserComputer
    {
        public int? CustomerId { get; set; }
        public string Os { get; set; }
        public Guid? Fatal { get; set; }
        public int? GetUserId { get; set; }
        public string Ip { get; set; }
        public string UserAgent { get; set; }
        public string Domain { get; set; }
        public int Id { get; set; }
        public string Browser { get; set; }
        public DateTime? DateIn { get; set; }
        public byte? SupportCamera { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users GetUser { get; set; }
    }
}
