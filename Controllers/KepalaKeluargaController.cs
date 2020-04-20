using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RTMilenial.Models;
using Microsoft.EntityFrameworkCore;

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
            List<StatusHuni> statusHunis = new List<StatusHuni>();
            statusHunis.Add(new StatusHuni{StatusHuniValue = "TTP", StatusHuniDisplay = "Tetap"});
            statusHunis.Add(new StatusHuni{StatusHuniValue = "KTR", StatusHuniDisplay = "Kontrak"});

            Task<List<SelectItemList>> t1 = Task<List<MasterBlokNo>>.Run(() => {
                return getMasterBlokNo();
            });

            Task.WaitAll(t1);

            ViewBag.lsBlokNo = t1.Result;
            ViewBag.lsStatusHuni = statusHunis;

            return View();
        }
        public KepalaKeluargaController(ILogger<KepalaKeluargaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateKK(VwAlamatKepalaKeluarga vwAlamatKepalaKeluarga)
        {
            if(ModelState.IsValid)
            {
                KepalaKeluarga kk = new KepalaKeluarga();
                AlamatKK akk = new AlamatKK();
                
                kk.Alamat = vwAlamatKepalaKeluarga.Alamat;
                kk.AuditActivity = "I";
                kk.AuditTime = DateTime.Now;
                kk.AuditUserName = "AdminUser";
                kk.DesaKelurahan = vwAlamatKepalaKeluarga.DesaKelurahan;
                kk.KabupatenKota = vwAlamatKepalaKeluarga.KabupatenKota;
                kk.Kecamatan = vwAlamatKepalaKeluarga.Kecamatan;
                kk.KodePos = vwAlamatKepalaKeluarga.KodePos;
                kk.NamaKk = vwAlamatKepalaKeluarga.NamaKk;
                kk.NoKk = vwAlamatKepalaKeluarga.NoKk;
                kk.Provinsi = vwAlamatKepalaKeluarga.Provinsi;
                kk.Rtrw = vwAlamatKepalaKeluarga.RtRw;
                
                akk.AuditActivity = "I";
                akk.AuditTime = DateTime.Now;
                akk.AuditUserName = "AdminUser";
                akk.BlokNoId = vwAlamatKepalaKeluarga.BlokNoId;
                akk.NamaPemilikRumah = vwAlamatKepalaKeluarga.NamaPemilikRumah;
                akk.NIKPemilikRumah = vwAlamatKepalaKeluarga.NIKPemilikRumah;
                akk.NoKk = vwAlamatKepalaKeluarga.NoKk;
                akk.NoSuratDomisili = vwAlamatKepalaKeluarga.NoSuratDomisili;
                akk.StatusHuniId = vwAlamatKepalaKeluarga.StatusHuniId;
                akk.TanggalHabisHuni = vwAlamatKepalaKeluarga.TanggalHabisHuni;
                akk.TanggalHuni = vwAlamatKepalaKeluarga.TanggalHuni;
                akk.TenorKPR = vwAlamatKepalaKeluarga.TenorKPR;

                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.KepalaKeluarga.Add(kk);
                        db.SaveChanges();

                        db.AlamatKK.Add(akk);
                        db.SaveChanges();

                        transaction.Commit();
                    }
                    catch (System.Exception)
                    {
                        transaction.Rollback();
                    }
                }

                return RedirectToAction("FetchKepalaKeluarga", "KepalaKeluarga");
            }
            return View("CreateKepalaKeluarga", vwAlamatKepalaKeluarga);
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
        
        public async Task<List<SelectItemList>> getMasterBlokNo()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterBlokNo> ma = new List<MasterBlokNo>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterBlokNo.OrderBy(s => s.Blok).ThenBy(s => s.BlokNo).ThenBy(s => s.NoRumah).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.BlokNoId,
                SelectDisplayMember = item.Blok + item.BlokNo + "/" + item.NoRumah});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Blok / No."});
            
            return selectItemLists;
        }

    }
}