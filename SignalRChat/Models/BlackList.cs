using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class BlackList
    {
        public int SupplierId { get; set; }
        public int CustomerId { get; set; }
        public int Id { get; set; }
        public DateTime? DateIn { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
