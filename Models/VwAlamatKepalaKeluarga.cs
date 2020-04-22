using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTMilenial.Models
{
    public partial class VwAlamatKepalaKeluarga
    {
        public string NoKk { get; set; }
        public string NamaKk { get; set; }
        public string Alamat { get; set; }
        public string RtRw { get; set; }
        public string DesaKelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string KabupatenKota { get; set; }
        public string KodePos { get; set; }
        public string Provinsi { get; set; }
        public string JalanId {get;set;}
        public string BlokNoRumah { get; set; }
        public string StatusHuniId {get;set;}
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? TanggalHuni {get;set;}
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? TanggalHabisHuni {get;set;}
        public string NIKPemilikRumah {get;set;}
        public string NamaPemilikRumah {get; set;}
        public int TenorKPR {get;set;}
        public string NoSuratDomisili {get;set;}
        
    }
}