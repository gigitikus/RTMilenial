using System;

namespace RTMilenial.Models
{
    public partial class VwKordinatorJalan
    {
        public string JalanId{get;set;}
        public string NamaJalan{get;set;}
        public string NamaKordinator{get;set;}
        public DateTime MasaJabatan{get;set;}
        public int TotalUnit{get;set;}
        public int UnitTerisi{get;set;}
        public int HuniTetap{get;set;}
        public int HuniKontrak{get;set;}
        public int JumlahKK{get;set;}
        public int JumlahWarga{get;set;}
    }
}