using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersProperties
    {
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public byte IsPublic { get; set; }
        public int UserId { get; set; }
        public DateTime DateIn { get; set; }

        public virtual Users User { get; set; }
    }
}
