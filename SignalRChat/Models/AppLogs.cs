using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class AppLogs
    {
        public int Id { get; set; }
        public int LogType { get; set; }
        public int UserrId { get; set; }
        public string LogMessage { get; set; }
        public DateTime DateIn { get; set; }

        public virtual Users Userr { get; set; }
    }
}
