using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Languages
    {
        public Languages()
        {
            SiteMessagesToLanguages = new HashSet<SiteMessagesToLanguages>();
        }

        public int Id { get; set; }
        public string Language { get; set; }
        public string LocalLanguage { get; set; }
        public string CurrentCulture { get; set; }

        public virtual ICollection<SiteMessagesToLanguages> SiteMessagesToLanguages { get; set; }
    }
}
