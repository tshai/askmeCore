using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class TicketViewDates
    {
        public int Id { get; set; }
        public int SupportNewId { get; set; }
        public DateTime DateIn { get; set; }

        public virtual SupportNew SupportNew { get; set; }
    }
}
