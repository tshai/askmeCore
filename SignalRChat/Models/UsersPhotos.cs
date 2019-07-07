using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersPhotos
    {
        public string PhotoGuid { get; set; }
        public DateTime DateIn { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
