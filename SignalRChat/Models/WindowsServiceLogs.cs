using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class WindowsServiceLogs
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateIn { get; set; }
        public string EventDesc { get; set; }
        public string RndNumber { get; set; }
        public int IsError { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
