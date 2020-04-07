using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTMilenial.Models
{
    public partial class KepalaKeluarga
    {
        public KepalaKeluarga()
        {
            AnggotaKeluarga = new HashSet<AnggotaKeluarga>();
        }

        [Required(ErrorMessage = "No. KK tidak boleh kosong")]
        public string NoKk { get; set; }
        [Required(ErrorMessage = "No. NIK tidak boleh kosong")]
        public string NIK {get;set;}
        [Required(ErrorMessage = "Nama KK tidak boleh kosong")]
        public string NamaKk { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }
        [Required(ErrorMessage = "RT/RW tidak boleh kosong")]
        public string Rtrw { get; set; }
        [Required(ErrorMessage = "Desa/Kelurahan tidak boleh kosong")]
        public string DesaKelurahan { get; set; }
        [Required(ErrorMessage = "Kecataman tidak boleh kosong")]
        public string Kecamatan { get; set; }
        [Required(ErrorMessage = "Kabupaten/Kota tidak boleh kosong")]
        public string KabupatenKota { get; set; }
        [Required(ErrorMessage = "Kode Pos tidak boleh kosong")]
        public string KodePos { get; set; }
        [Required(ErrorMessage = "Provinsi tidak boleh kosong")]
        public string Provinsi { get; set; }
        public string AuditUserName { get; set; }
        public DateTime AuditTime { get; set; }
        public string AuditActivity { get; set; }

        public virtual ICollection<AnggotaKeluarga> AnggotaKeluarga { get; set; }
    }
}
