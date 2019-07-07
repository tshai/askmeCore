using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class EmployeeManageLevels
    {
        public EmployeeManageLevels()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
