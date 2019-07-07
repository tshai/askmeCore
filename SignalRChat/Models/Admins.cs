using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Admins
    {
        public Admins()
        {
            AdminsLogins = new HashSet<AdminsLogins>();
        }

        public int Id { get; set; }
        public DateTime? DateIn { get; set; }
        public string AdminName { get; set; }
        public string Passowrd { get; set; }
        public byte? Permissions { get; set; }

        public virtual ICollection<AdminsLogins> AdminsLogins { get; set; }
    }
}
