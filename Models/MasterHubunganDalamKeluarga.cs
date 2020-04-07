using System;
using System.Collections.Generic;

namespace RTMilenial.Models
{
    public partial class MasterHubunganDalamKeluarga
    {
        public string HubunganDalamKeluarga {get;set;}
        public string HubunganDalamKeluargaDescription {get;set;}
        public int OrderNo {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}