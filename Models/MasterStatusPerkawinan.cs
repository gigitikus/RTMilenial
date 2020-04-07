using System;
using System.Collections.Generic;

namespace RTMilenial.Models
{
    public partial class MasterStatusPerkawinan
    {
        public string StatusPerkawinan{get;set;}
        public string StatusPerkawinanDescription {get;set;}
        public int OrderNo {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}