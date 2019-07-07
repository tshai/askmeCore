using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class LogLastVisit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte Gender { get; set; }
        public DateTime DateIn { get; set; }
        public byte Status { get; set; }

        public virtual Users User { get; set; }
    }
}
