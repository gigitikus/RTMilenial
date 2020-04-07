using System;
using System.Collections.Generic;

namespace RTMilenial.Models
{
    public partial class MasterAgama
    {
        public string Agama{get;set;}
        public string AgamaDescription {get;set;}
        public int OrderNo {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}