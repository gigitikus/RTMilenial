using System;
using System.Collections.Generic;

namespace RTMilenial.Models
{
    public partial class MasterPendidikan
    {
        public string Pendidikan {get;set;}
        public string PendidikanDescription {get;set;}
        public int OrderNo {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}