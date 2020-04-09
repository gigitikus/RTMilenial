using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RTMilenial.Models;

namespace RTMilenial.Controllers
{
    public class AnggotaKeluargaController : Controller
    {
        private readonly ILogger<AnggotaKeluargaController> _logger;
        MyDbContext db = new MyDbContext();

        public AnggotaKeluargaController(ILogger<AnggotaKeluargaController> logger)
        {
            _logger = logger;
        } 

        public ActionResult FetchAnggotaKeluarga()
        {
            return View(db.AnggotaKeluarga.ToList().OrderBy(m => m.NoKk).ThenBy(n => n.NoUrut));
        }

        public ActionResult CreateAnggotaKeluarga(string NoKK, string NamaKK)
        {
            IEnumerable<AnggotaKeluarga> ak = db.AnggotaKeluarga.ToList().Where(s => s.NoKk == NoKK.Trim());
            ViewBag.lsAnggotaKeluarga = ak;
            ViewBag.noKK = NoKK.Trim();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAnggotaKeluarga(AnggotaKeluarga anggotaKeluarga)
        {
            KepalaKeluarga kk = db.KepalaKeluarga.Where(s => s.NoKk == anggotaKeluarga.NoKk.Trim()).FirstOrDefault();

            if(ModelState.IsValid)
            {
                anggotaKeluarga.AuditActivity = "I";
                anggotaKeluarga.AuditTime = DateTime.Now;
                anggotaKeluarga.AuditUserName = "AdminUser";
                db.AnggotaKeluarga.Add(anggotaKeluarga);
                db.SaveChanges();
                return RedirectToAction("CreateAnggotaKeluarga", "AnggotaKeluarga",
                new {NoKk = anggotaKeluarga.NoKk, NamaKk = kk.NamaKk});
            }
            return RedirectToAction("CreateAnggotaKeluarga", "AnggotaKeluarga",
                new {NoKk = anggotaKeluarga.NoKk, NamaKk = kk.NamaKk});
        }

        [HttpPost]
        public bool DeleteAnggotaKeluarga(string NoKk, int NoUrut, string Nik)
        {
            try 
            {
                AnggotaKeluarga ak = db.AnggotaKeluarga.Where(s => s.NoKk == NoKk.Trim() && 
                s.NoUrut == NoUrut && s.Nik == Nik.Trim()).FirstOrDefault();
                db.AnggotaKeluarga.Remove(ak);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public ActionResult UpdateAnggotaKeluarga(string NoKk, int NoUrut, string Nik)
        {
            return View(db.AnggotaKeluarga.Where(s => s.NoKk == NoKk.Trim() && 
                s.NoUrut == NoUrut && s.Nik == Nik.Trim()).FirstOrDefault());
        }

        public ActionResult UpdateAnggotaKeluarga(AnggotaKeluarga ak)
        {
            AnggotaKeluarga aks = db.AnggotaKeluarga.Where(s => s.NoKk == ak.NoKk.Trim() && 
                s.NoUrut == ak.NoUrut && s.Nik == ak.Nik.Trim()).FirstOrDefault();
                aks.Agama = ak.Agama;
                aks.AuditActivity = "U";
                aks.AuditTime = DateTime.Now;
                aks.AuditUserName = "AdminUser";
                aks.Ayah = ak.Ayah;
                aks.HubunganDalamKeluarga = ak.HubunganDalamKeluarga;
                aks.Ibu = ak.Ibu;
                aks.JenisKelamin = ak.JenisKelamin;
                aks.JenisPekerjaan = ak.JenisPekerjaan;
                aks.Kawarganegaraan = ak.Kawarganegaraan;
                aks.NamaLengkap = ak.NamaLengkap;
                aks.NoKitas = ak.NoKitas;
                aks.NoPaspor = ak.NoPaspor;
                aks.Pendidikan = ak.Pendidikan;
                aks.StatusPerkawinan = ak.StatusPerkawinan;
                aks.TanggalLahir = ak.TanggalLahir;
                aks.TempatLahir = ak.TempatLahir;
                db.SaveChanges();
                return RedirectToAction("FecthAnggotaKeluarga", "AnggotaKeluarga");
        }
    }
}