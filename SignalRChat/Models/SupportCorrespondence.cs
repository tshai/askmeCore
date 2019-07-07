using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SupportCorrespondence
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public int SupportId { get; set; }
        public string Cmessage { get; set; }
        public byte WhoSend { get; set; }
        public string Sguid { get; set; }
        public int SupplierId { get; set; }
        public string Img { get; set; }
        public byte HasImages { get; set; }
        public int EmployeeId { get; set; }
        public string Sms { get; set; }

        public virtual SupportNew Support { get; set; }
    }
}
