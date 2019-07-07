using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class AdminToUsersNews
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public string FreeText { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public int? FontSize { get; set; }
    }
}
