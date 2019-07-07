using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SiteMessagesToLanguages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int? SiteMessageId { get; set; }
        public int? LanguageId { get; set; }
        public DateTime? DateIn { get; set; }

        public virtual Languages Language { get; set; }
        public virtual SiteMessages SiteMessage { get; set; }
    }
}
