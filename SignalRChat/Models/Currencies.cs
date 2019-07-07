using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Currencies
    {
        public Currencies()
        {
            CountryList = new HashSet<CountryList>();
            SupplierToServicePrice = new HashSet<SupplierToServicePrice>();
        }

        public int Id { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }
        public double MultipleFromDollar { get; set; }
        public string CurrencySide { get; set; }

        public virtual ICollection<CountryList> CountryList { get; set; }
        public virtual ICollection<SupplierToServicePrice> SupplierToServicePrice { get; set; }
    }
}
