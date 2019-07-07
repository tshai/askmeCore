using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class SupportImages
    {
        public int Id { get; set; }
        public int SupportCorrespondenceId { get; set; }
        public string ImgName { get; set; }
        public DateTime DateIn { get; set; }
    }
}
