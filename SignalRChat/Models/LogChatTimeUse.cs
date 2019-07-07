using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class LogChatTimeUse
    {
        public int TimeUse { get; set; }
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime Dateout { get; set; }
        public int SupplierId { get; set; }
        public Guid? RndNum { get; set; }
        public int CustomerId { get; set; }
        public int? SessionStatus { get; set; }
        public int? UserAskToDelete { get; set; }
        public byte? UserValidate { get; set; }
        public byte? FullCharge { get; set; }
        public byte? BehindScreens { get; set; }
        public byte? SendMessage { get; set; }
        public decimal? MultiplySum { get; set; }
        public byte? UserConnectToGirlFms { get; set; }
        public byte? IsTablet { get; set; }
        public byte? VersionNum { get; set; }
        public string PlayerReferrer { get; set; }
        public string EndError { get; set; }
        public byte RemoveStartTime { get; set; }
        public int? PerformerSeeTimeUse { get; set; }

        public virtual Users Customer { get; set; }
        public virtual Users Supplier { get; set; }
    }
}
