using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class AdminPages
    {
        public int? AdminId { get; set; }
        public int Id { get; set; }
        public DateTime? DateIn { get; set; }
        public string PageName { get; set; }
        public int? LoginId { get; set; }
    }
}
