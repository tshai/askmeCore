using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class ChatTimeUse
    {
        public ChatTimeUse()
        {
            UsersToUsersServicesPayments = new HashSet<UsersToUsersServicesPayments>();
        }

        public int Id { get; set; }
        public int TimeUse { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime Dateout { get; set; }
        public int SupplierId { get; set; }
        public Guid? RndNum { get; set; }
        public int CustomerId { get; set; }
        public bool SessionStatus { get; set; }
        public int UserAskToDelete { get; set; }
        public string EndError { get; set; }
        public int? DomainId { get; set; }
        public int VersionId { get; set; }
        public double? SupplierDiscount { get; set; }
        public DateTime? AnswerDateIn { get; set; }
        public Guid ChatTimeUseGuid { get; set; }
        public byte IsAnswer { get; set; }
        public byte CallViewStatus { get; set; }
        public byte IsPayPerMinute { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
        public virtual ICollection<UsersToUsersServicesPayments> UsersToUsersServicesPayments { get; set; }
    }
}
