using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateIn { get; set; }
        public int ManageLevel { get; set; }
        public byte Active { get; set; }

        public virtual EmployeeManageLevels ManageLevelNavigation { get; set; }
    }
}
