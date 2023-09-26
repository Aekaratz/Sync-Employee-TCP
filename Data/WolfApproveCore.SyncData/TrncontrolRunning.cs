using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrncontrolRunning
    {
        public int ControlRunningOrder { get; set; }
        public int? TemplateId { get; set; }
        public string Prefix { get; set; }
        public int? Digit { get; set; }
        public int? Running { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RunningNumber { get; set; }
    }
}
