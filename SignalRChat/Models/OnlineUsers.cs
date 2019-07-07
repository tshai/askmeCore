using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class OnlineUsers
    {
        public int Online { get; set; }
        public int SupplierId { get; set; }
        public DateTime SupplierLastVisit { get; set; }
        public DateTime CustomerLastVisit { get; set; }
        public int CustomerId { get; set; }
        public Guid RndNumber { get; set; }
        public int SupplierGettingCustomer { get; set; }
        public int LastCustomerId { get; set; }
        public DateTime LastStatusChange { get; set; }
        public byte FreeChat { get; set; }
        public DateTime TimeTheChatStart { get; set; }
        public byte LiveMessage { get; set; }
        public int SumUserTime { get; set; }
        public int IsQa { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
