using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class RoomConversation
    {
        public int Id { get; set; }
        public int SendUserId { get; set; }
        public int SupplierId { get; set; }
        public string Conversation { get; set; }
        public DateTime DateIn { get; set; }
        public bool WhoSend { get; set; }
        public byte GetUserRead { get; set; }
        public byte SendUserRead { get; set; }
        public Guid RndNumber { get; set; }

        public virtual Users SendUser { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
