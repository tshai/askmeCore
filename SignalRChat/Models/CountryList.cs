using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class CountryList
    {
        public CountryList()
        {
            DomainsList = new HashSet<DomainsList>();
        }

        public string CountryName { get; set; }
        public int Id { get; set; }
        public int TimeZoneId { get; set; }
        public int CurrencyId { get; set; }
        public int LanguageId { get; set; }
        public double? SiteRevenue { get; set; }
        public string CountryCode { get; set; }
        public string Lc { get; set; }
        public string DefaultCountryCode { get; set; }
        public string CultureInfo { get; set; }
        public string InphonePrefix { get; set; }
        public int SiteMessageId { get; set; }

        public virtual Currencies Currency { get; set; }
        public virtual ICollection<DomainsList> DomainsList { get; set; }
    }
}
