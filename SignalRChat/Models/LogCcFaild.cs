using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class LogCcFaild
    {
        public decimal? IdNumber { get; set; }
        public string LastDigits { get; set; }
        public string ErrorNum { get; set; }
        public DateTime DateIn { get; set; }
        public int ColNum { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string YearDate { get; set; }
        public string MonthDate { get; set; }
        public string Cvv { get; set; }
        public string TransactionProcessor { get; set; }
        public string IpAddress { get; set; }
        public byte? Status { get; set; }
        public string Cccountry { get; set; }
        public string Country { get; set; }

        public virtual Users User { get; set; }
    }
}
