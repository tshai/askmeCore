using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersToUsers
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public DateTime DateIn { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
