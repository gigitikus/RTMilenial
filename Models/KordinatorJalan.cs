using System;

namespace RTMilenial.Models
{
    public partial class KordinatorJalan
    {
        public string JalanId {get;set;}
        public string NIK {get;set;}
        public bool Status {get;set;}
        public DateTime MasaJabatan {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}