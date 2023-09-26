using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.Center
{
    public partial class ContactU
    {
        public int ContactId { get; set; }
        public string ContactCode { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string CompanyName { get; set; }
        public string Tel { get; set; }
        public string Prefix { get; set; }
        public string ConnectionString { get; set; }
        public string Account { get; set; }
        public string AdminAccount { get; set; }
        public DateTime? RequesDate { get; set; }
        public string Status { get; set; }
        public string TinyUrl { get; set; }
        public string SharepointSiteUrl { get; set; }
        public string SharepointSiteAdmin { get; set; }
        public string ApiUrl { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public string LogoPath { get; set; }
        public string Smtpconfig { get; set; }
    }
}
