using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Smslogs
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Answer { get; set; }
        public DateTime DateIn { get; set; }
        public string Processor { get; set; }
    }
}
