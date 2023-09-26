using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnuserParticipate
    {
        public int Upid { get; set; }
        public string DocumentNo { get; set; }
        public int? UserParticipateId { get; set; }
        public string UserParticipateName { get; set; }
        public string StatusName { get; set; }
        public string ActionName { get; set; }
        public bool? IsProcess { get; set; }
    }
}
