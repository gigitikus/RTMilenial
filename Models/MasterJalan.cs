using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTMilenial.Models
{
    public partial class MasterJalan
    {
        public string JalanId {get;set;}
        public string NamaJalan {get;set;}
        public int OrderNo {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}