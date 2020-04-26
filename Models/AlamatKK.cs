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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
        public DateTime TanggalHuni {get;set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
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