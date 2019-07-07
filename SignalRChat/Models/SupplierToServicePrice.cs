using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SupplierToServicePrice
    {
        public SupplierToServicePrice()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int SupplierId { get; set; }
        public DateTime DateIn { get; set; }
        public double PricePerMinute { get; set; }
        public int CurrencyId { get; set; }
        public Guid SupplierToServicePriceGuid { get; set; }
        public double PricePerMessage { get; set; }

        public virtual Currencies Currency { get; set; }
        public virtual Users Supplier { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
