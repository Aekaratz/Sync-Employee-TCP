using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Page { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedBy { get; set; }
        public string Platform { get; set; }
        public string Site { get; set; }
    }
}
