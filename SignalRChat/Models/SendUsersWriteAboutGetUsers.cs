using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SendUsersWriteAboutGetUsers
    {
        public DateTime DateIn { get; set; }
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string FreeText { get; set; }
        public int SendUserId { get; set; }
        public decimal? IdNumber { get; set; }

        public virtual Users SendUser { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
