using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class PrepaidBin
    {
        public int Id { get; set; }
        public string Bin { get; set; }
        public DateTime DateIn { get; set; }
    }
}
