using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersLoggedIn
    {
        public DateTime DateIn { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string IpAddress { get; set; }
        public bool? Gender { get; set; }
        public byte Success { get; set; }
        public string BrowserDetails { get; set; }
        public string Password { get; set; }
        public string SessionId { get; set; }

        public virtual Users User { get; set; }
    }
}
