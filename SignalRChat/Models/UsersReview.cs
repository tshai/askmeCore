using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersReview
    {
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public int Id { get; set; }
        public string FreeText { get; set; }
        public DateTime DateIn { get; set; }
        public int Activate { get; set; }
        public string FreeTextEn { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
