using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTMilenial.Models
{
    public partial class AlamatKK
    {
        public string NoKk { get; set; }
        public string BlokNoRumah { get; set; }
        public string StatusHuniId {get;set;}
        public DateTime TanggalHuni {get;set;}
        public DateTime TanggalHabisHuni {get;set;}
        public string NIKPemilikRumah {get;set;}
        public string NamaPemilikRumah {get; set;}
        public int TenorKPR {get;set;}
        public string NoSuratDomisili {get;set;}
        public string AuditUserName { get; set; }
        public DateTime AuditTime { get; set; }
        public string AuditActivity { get; set; }
    }
}