using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Setting
    {
        public int UsersActive { get; set; }
        public string UserMessage { get; set; }
        public int Id { get; set; }
        public decimal PaySumParam { get; set; }
        public DateTime WindowsServiceLastUpdate { get; set; }
        public int? UserAppVersionId { get; set; }
        public int? UserAppForceVesion { get; set; }
        public int VideoResoultionWidth { get; set; }
        public int VideoResoultionHeight { get; set; }
        public int FramePerSecond { get; set; }
        public int? MessageForAppUserUpgrade { get; set; }
        public byte? SaveLogForWebRtc { get; set; }

        public virtual Versions UserAppVersion { get; set; }
    }
}
