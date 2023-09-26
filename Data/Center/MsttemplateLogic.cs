using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.Center
{
    public partial class MsttemplateLogic
    {
        public int AutoId { get; set; }
        public Guid Logicid { get; set; }
        public int? TemplateId { get; set; }
        public int? Seq { get; set; }
        public string Logictype { get; set; }
        public string Jsonvalue { get; set; }
    }
}
