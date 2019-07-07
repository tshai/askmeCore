using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Prices
    {
        public int Id { get; set; }
        public int? PriceIls { get; set; }
        public int? TimeExpire { get; set; }
        public string TextHe { get; set; }
        public string DiscountText { get; set; }
        public byte? PriceStatus { get; set; }
        public int? PriceEur { get; set; }
    }
}
