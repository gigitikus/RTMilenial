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
            Task<List<KepalaKeluarga>> t1 = Task<List<KepalaKeluarga>>.Run(() => {
                return GetKepalaKeluargas();
            });

            Task<List<AlamatKK>> t2 = Task<List<AlamatKK>>.Run(() => {
                return GetAlamatKKs();
            });

            Task<List<MasterBlokNoRumah>> t3 = Task<List<MasterBlokNoRumah>>.Run(() => {
                return GetMasterBlokNoRumahs();
            });

            Task<List<MasterJalan>> t4 = Task<List<MasterJalan>>.Run(() => {
                return GetMasterJalans();
            });

            Task.WaitAll(t1, t2, t3, t4);

            var joinTbl = (from kk in t1.Result 
                            join akk in t2.Result on kk.NoKk equals akk.NoKk
                            join mbr in t3.Result on akk.BlokNoRumah equals mbr.BlokNoRumah
                            join mj in t4.Result on mbr.JalanId equals mj.JalanId
                            select new {
                                NoKK = kk.NoKk,
                                NamaKK = kk.NamaKk,
                                Alamat = kk.Alamat,
                                RTRW = kk.Rtrw,
                                DesaKelurahan = kk.DesaKelurahan,
                                Kecamatan = kk.Kecamatan,
                                KabupatenKota = kk.KabupatenKota,
                                KodePos = kk.KodePos,
                                Provinsi = kk.Provinsi,
                                Blok = mbr.Blok,
                                BlokNo = mbr.BlokNo,
                                NoRumah = mbr.NoRumah,
                                NamaJalan = mj.NamaJalan
                            }
                            ).ToList();
            
            List<FetchAlamatKK> fetchAlamatKKs = new List<FetchAlamatKK>();

            foreach(var item in joinTbl)
            {
                fetchAlamatKKs.Add(new FetchAlamatKK{
                    NoKK = item.NoKK,
                    NamaKK = item.NamaKK,
                    Alamat = item.Alamat,
                    RTRW = item.RTRW,
                    DesaKelurahan = item.DesaKelurahan,
                    Kecamatan = item.Kecamatan,
                    KabupatenKota = item.KabupatenKota,
                    KodePos = item.KodePos,
                    Provinsi = item.Provinsi,
                    Blok = item.Blok,
                    BlokNo = item.BlokNo,
                    NoRumah = item.NoRumah,
                    NamaJalan = item.NamaJalan
                });
            }

            return View(fetchAlamatKKs);
            //return View(db.KepalaKeluarga.ToList().OrderBy(m => m.NamaKk));
        }

        public ActionResult CreateKepalaKeluarga()
        {
            List<StatusHuni> statusHunis = new List<StatusHuni>();
            statusHunis.Add(new StatusHuni{StatusHuniValue = "TTP", StatusHuniDisplay = "Tetap"});
            statusHunis.Add(new StatusHuni{StatusHuniValue = "KTR", StatusHuniDisplay = "Kontrak"});

            // Task<List<SelectItemList>> t1 = Task<List<SelectItemList>>.Run(() => {
            //     return getMasterBlokNo();
            // });

            Task<List<SelectItemList>> t2 = Task<List<SelectItemList>>.Run(() => {
                return getMasterJalan();
            });

            Task.WaitAll(t2);

            /*
            List<SelectItemList> blokNos = new List<SelectItemList>();
            if(!string.IsNullOrEmpty(jalanId))
            {
                var BlokNoIds = db.MasterBlokNo.Where(x => x.JalanId == jalanId.Trim())
                .OrderBy(x => x.Blok).ThenBy(x => x.BlokNo).ThenBy(x => x.NoRumah).ToList();

                foreach(var item in BlokNoIds)
                {
                    blokNos.Add(new SelectItemList{SelectValueMember = item.BlokNoId,
                    SelectDisplayMember = item.Blok + item.BlokNo + "/" + item.NoRumah});
                }
            }
            */

            //ViewBag.lsBlokNo = blokNos;
            ViewBag.lsNamaJalan = t2.Result;
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
                akk.BlokNoRumah = vwAlamatKepalaKeluarga.BlokNoRumah;
                akk.NamaPemilikRumah = vwAlamatKepalaKeluarga.NamaPemilikRumah;
                akk.NIKPemilikRumah = vwAlamatKepalaKeluarga.NIKPemilikRumah;
                akk.NoKk = vwAlamatKepalaKeluarga.NoKk;
                akk.NoSuratDomisili = vwAlamatKepalaKeluarga.NoSuratDomisili;
                akk.StatusHuniId = vwAlamatKepalaKeluarga.StatusHuniId;

                if(vwAlamatKepalaKeluarga.TanggalHuni == null)
                {
                    akk.TanggalHabisHuni = DateTime.MinValue;
                }

                if(vwAlamatKepalaKeluarga.TanggalHabisHuni == null)
                {
                    akk.TanggalHuni = DateTime.MinValue;
                }
                
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
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
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
        
        public async Task<List<KepalaKeluarga>> GetKepalaKeluargas()
        {
            List<KepalaKeluarga> Result = new List<KepalaKeluarga>();
            using (var dataContext = new MyDbContext())
            {
                Result = await dataContext.KepalaKeluarga.ToListAsync();
            }

            return Result;
        }

        public async Task<List<AlamatKK>> GetAlamatKKs()
        {
            List<AlamatKK> Result = new List<AlamatKK>();
            using (var dataContext = new MyDbContext())
            {
                Result = await dataContext.AlamatKK.ToListAsync();
            }

            return Result;
        }

        public async Task<List<MasterBlokNoRumah>> GetMasterBlokNoRumahs()
        {
            List<MasterBlokNoRumah> Result = new List<MasterBlokNoRumah>();
            using (var dataContext = new MyDbContext())
            {
                Result = await dataContext.MasterBlokNoRumah.ToListAsync();
            }

            return Result;
        }

        public async Task<List<MasterJalan>> GetMasterJalans()
        {
            List<MasterJalan> Result = new List<MasterJalan>();
            using (var dataContext = new MyDbContext())
            {
                Result = await dataContext.MasterJalan.ToListAsync();
            }

            return Result;
        }

        public async Task<List<SelectItemList>> getMasterBlokNo()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterBlokNoRumah> ma = new List<MasterBlokNoRumah>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterBlokNoRumah.OrderBy(s => s.Blok).ThenBy(s => s.BlokNo).ThenBy(s => s.NoRumah).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.BlokNoRumah,
                SelectDisplayMember = item.Blok + item.BlokNo + "/" + item.NoRumah});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Blok / No."});
            
            return selectItemLists;
        }

        public async Task<List<SelectItemList>> getMasterJalan()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterJalan> ma = new List<MasterJalan>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterJalan.OrderBy(s => s.OrderNo).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.JalanId,
                SelectDisplayMember = item.NamaJalan});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Nama Jalan"});
            
            return selectItemLists;
        }

        public JsonResult GetBlokNoRumah(string jalanId)
        {
            List<MasterBlokNoRumah> blokNos = db.MasterBlokNoRumah.Where(x => x.JalanId.Trim() == jalanId.Trim()).ToList();

            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            foreach (var item in blokNos)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.BlokNoRumah,
                SelectDisplayMember = item.Blok + item.BlokNo + "/" + item.NoRumah});
            }

            var Result = (from item in selectItemLists 
                            select new 
                            {
                                value = item.SelectValueMember,
                                text = item.SelectDisplayMember
                            }).ToList();

            return Json(Result);
        }
    }
}