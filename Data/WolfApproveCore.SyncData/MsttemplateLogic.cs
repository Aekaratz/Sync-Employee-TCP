using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MsttemplateLogic
    {
        public Guid Logicid { get; set; }
        public int? TemplateId { get; set; }
        public int? Seq { get; set; }
        public string Logictype { get; set; }
        public string Jsonvalue { get; set; }
    }
}
