using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Versions
    {
        public Versions()
        {
            Setting = new HashSet<Setting>();
        }

        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public string VersionNumber { get; set; }

        public virtual ICollection<Setting> Setting { get; set; }
    }
}
