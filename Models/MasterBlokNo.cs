using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTMilenial.Models
{
    public partial class MasterBlokNo
    {
        public string BlokNoId {get;set;}
        public string Blok {get;set;}
        public int BlokNo {get;set;}
        public int NoRumah {get;set;}
        public string JalanId {get;set;}
        public string AuditUserName {get;set;}
        public DateTime AuditTime {get;set;}
        public string AuditActivity {get;set;}
    }
}