using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SupportNew
    {
        public SupportNew()
        {
            SupportCorrespondence = new HashSet<SupportCorrespondence>();
            TicketViewDates = new HashSet<TicketViewDates>();
        }

        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public byte Department { get; set; }
        public string Cmessage { get; set; }
        public string Sguid { get; set; }
        public int? UserId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public byte IsReadCustomer { get; set; }
        public byte? IsReadSupport { get; set; }
        public byte TicketsStatus { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Topic { get; set; }
        public string IpAddress { get; set; }
        public byte AdminHide { get; set; }
        public int? SupplierId { get; set; }
        public int DomainsListId { get; set; }
        public int EmployeeId { get; set; }
        public int? NewId { get; set; }
        public int OrderId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<SupportCorrespondence> SupportCorrespondence { get; set; }
        public virtual ICollection<TicketViewDates> TicketViewDates { get; set; }
    }
}
