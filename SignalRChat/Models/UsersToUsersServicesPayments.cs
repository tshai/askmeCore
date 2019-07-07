using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class UsersToUsersServicesPayments
    {
        public int Id { get; set; }
        public int? UsersToUsersMessagesId { get; set; }
        public int SupplierToServicePriceId { get; set; }
        public double CustomerMultipleFromDollar { get; set; }
        public double SupplierMultipleFromDollar { get; set; }
        public double TotalPriceInDollar { get; set; }
        public int? ChatTimeUseId { get; set; }
        public int? CustomerId { get; set; }

        public virtual ChatTimeUse ChatTimeUse { get; set; }
        public virtual Users Customer { get; set; }
        public virtual UsersToUsersMessages UsersToUsersMessages { get; set; }
    }
}
