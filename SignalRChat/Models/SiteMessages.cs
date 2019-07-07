using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SiteMessages
    {
        public SiteMessages()
        {
            SiteMessagesToLanguages = new HashSet<SiteMessagesToLanguages>();
        }

        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DateIn { get; set; }
        public int? DataType { get; set; }

        public virtual ICollection<SiteMessagesToLanguages> SiteMessagesToLanguages { get; set; }
    }
}
