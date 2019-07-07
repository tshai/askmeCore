using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SupportChat
    {
        public int Id { get; set; }
        public int StudioId { get; set; }
        public string ChatText { get; set; }
        public DateTime DateIn { get; set; }
        public byte IsAdmin { get; set; }

        public virtual Studios Studio { get; set; }
    }
}
