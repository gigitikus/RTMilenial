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
    public class KepalaKeluargaController : Controller
    {
        private readonly ILogger<KepalaKeluargaController> _logger;
        MyDbContext db = new MyDbContext();

        public ActionResult FetchKepalaKeluarga()
        {
            return View(db.KepalaKeluarga.ToList().OrderBy(m => m.NamaKk));
        }

        public ActionResult CreateKepalaKeluarga()
        {
            return View();
        }
        public KepalaKeluargaController(ILogger<KepalaKeluargaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateKK(KepalaKeluarga kepalaKeluarga)
        {
            if(ModelState.IsValid)
            {
                kepalaKeluarga.AuditUserName = "AdminUser";
                kepalaKeluarga.AuditTime = DateTime.Now;
                kepalaKeluarga.AuditActivity = "I";
                db.KepalaKeluarga.Add(kepalaKeluarga);
                db.SaveChanges();
                return RedirectToAction("FetchKepalaKeluarga", "KepalaKeluarga");
            }
            return View("CreateKepalaKeluarga", kepalaKeluarga);
        }

        [HttpPost]
        public bool DeleteKK(string NoKK)
        {
            try 
            {
                KepalaKeluarga kk = db.KepalaKeluarga.Where(s => s.NoKk == NoKK.Trim()).FirstOrDefault();
                db.KepalaKeluarga.Remove(kk);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;    
            }
        }

        public ActionResult Update(string NoKK)
        {
            return View(db.KepalaKeluarga.Where(s => s.NoKk == NoKK.Trim()).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult UpdateKK(KepalaKeluarga kk)
        {
            KepalaKeluarga d = db.KepalaKeluarga.Where(s => s.NoKk == kk.NoKk.Trim()).FirstOrDefault();
            d.Alamat = kk.Alamat;
            d.AuditActivity = "U";
            d.AuditTime = DateTime.Now;
            d.AuditUserName = "SystemAdmin";
            d.DesaKelurahan = kk.DesaKelurahan;
            d.KabupatenKota = kk.KabupatenKota;
            d.Kecamatan = kk.Kecamatan;
            d.KodePos = kk.KodePos;
            d.NamaKk = kk.NamaKk;
            d.NoKk = kk.NoKk;
            d.Provinsi = kk.Provinsi;
            d.Rtrw = kk.Rtrw;
            db.SaveChanges();
            return RedirectToAction("KepalaKeluarga", "KepalaKeluargas");
        }
        
    }
}