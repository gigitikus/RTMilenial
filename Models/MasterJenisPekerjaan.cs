using System;
using System.Collections.Generic;

namespace RTMilenial.Models
{
    public partial class MasterJenisPekerjaan
    {
        public string JenisPekerjaan {get;set;}
        public string JenisPekerjaanDescription {get;set;}
        public int OrderNo {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}