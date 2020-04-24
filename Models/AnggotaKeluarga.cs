using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RTMilenial.Models
{
    public partial class AnggotaKeluarga
    {
        [Required(ErrorMessage = "No. KK tidak boleh kosong")]
        public string NoKk { get; set; }
        public int NoUrut { get; set; }
        [Required(ErrorMessage = "Nama Lengkap tidak boleh kosong")]
        public string NamaLengkap { get; set; }
        [Required(ErrorMessage = "NIK tidak boleh kosong")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Jenis Kelamin tidak boleh kosong")]
        public string JenisKelamin { get; set; }
        [Required(ErrorMessage = "Tempat Lahir tidak boleh kosong")]
        public string TempatLahir { get; set; }

        [Required(ErrorMessage = "Tanggal Lahir tidak boleh kosong")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
        public DateTime TanggalLahir {get;set;}
        [Required(ErrorMessage = "Kamu belum memilih Agama")]
        public string Agama { get; set; }
        [Required(ErrorMessage = "Kamu belum memilih Pendidikan")]
        public string Pendidikan { get; set; }
        [Required(ErrorMessage = "Kamu belum memilih Pekerjaan")]
        public string JenisPekerjaan { get; set; }
        [Required(ErrorMessage = "Kamu belum memilih Status Perkawinan")]
        public string StatusPerkawinan { get; set; }
        [Required(ErrorMessage = "Kamu belum memilih Hubungan Keluarga")]
        public string HubunganDalamKeluarga { get; set; }
        public string Kawarganegaraan { get; set; }
        public string NoPaspor { get; set; }
        public string NoKitas { get; set; }
        [Required(ErrorMessage = "Ayah Kandung tidak boleh kosong")]
        public string Ayah { get; set; }
        [Required(ErrorMessage = "Ibu Kandung tidak boleh kosong")]
        public string Ibu { get; set; }
        public string AuditUserName { get; set; }
        public DateTime AuditTime { get; set; }
        public string AuditActivity { get; set; }

        public virtual KepalaKeluarga NoKkNavigation { get; set; }
    }
}
