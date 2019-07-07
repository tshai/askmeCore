using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class NotsAboutCustomers
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public string Note { get; set; }
        public int SupplierId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public string IdNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual Users Customer { get; set; }
    }
}
