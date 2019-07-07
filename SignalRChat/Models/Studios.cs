using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Studios
    {
        public Studios()
        {
            SupportChat = new HashSet<SupportChat>();
        }

        public int Id { get; set; }
        public DateTime? DateIn { get; set; }
        public string FreeText { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte? Active { get; set; }
        public string Name { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public string RealName { get; set; }
        public int? PhoneFeed { get; set; }
        public int? ShiftBonus { get; set; }
        public int? PercentageToModels { get; set; }
        public int OpenCall { get; set; }
        public int CreateCall { get; set; }

        public virtual ICollection<SupportChat> SupportChat { get; set; }
    }
}
