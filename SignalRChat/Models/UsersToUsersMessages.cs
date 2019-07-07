using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersToUsersMessages
    {
        public UsersToUsersMessages()
        {
            UsersToUsersServicesPayments = new HashSet<UsersToUsersServicesPayments>();
        }

        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string MessageText { get; set; }
        public byte MessageRead { get; set; }
        public byte SendUserDelete { get; set; }
        public byte GetUserDelete { get; set; }
        public byte SenderDeleteForAll { get; set; }
        public byte MustRead { get; set; }
        public byte MessageType { get; set; }
        public string VideoImage { get; set; }
        public string MessageGuid { get; set; }

        public virtual ICollection<UsersToUsersServicesPayments> UsersToUsersServicesPayments { get; set; }
    }
}
