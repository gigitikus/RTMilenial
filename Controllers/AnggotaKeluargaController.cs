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
            //Fix Mantap
            IEnumerable<AnggotaKeluarga> ak = db.AnggotaKeluarga.ToList().Where(s => s.NoKk == NoKK.Trim()).OrderBy(x => x.NoUrut);
            
            List<JenisKelamin> jenisKelamins = new List<JenisKelamin>();
            jenisKelamins.Add(new JenisKelamin{JenisKelaminValue = "", JenisKelaminDisplay = "Pilih Jenis Kelamin"});
            jenisKelamins.Add(new JenisKelamin{JenisKelaminValue = "LAKI-LAKI", JenisKelaminDisplay = "Laki-Laki"});
            jenisKelamins.Add(new JenisKelamin{JenisKelaminValue = "PEREMPUAN", JenisKelaminDisplay = "Perempuan"});

            List<Kewarganegaraan> kewarganegaraans = new List<Kewarganegaraan>();
            kewarganegaraans.Add(new Kewarganegaraan{KewarganegaraanValue = "WNI", KewarganegaraanDisplay = "WNI"});
            kewarganegaraans.Add(new Kewarganegaraan{KewarganegaraanValue = "WNA", KewarganegaraanDisplay = "WNA"});

            Task<List<SelectItemList>> t1 = Task<List<SelectItemList>>.Run(() => {
                return getMasterAgama();
            });

            Task<List<SelectItemList>> t2 = Task<List<SelectItemList>>.Run(() => {
                return getMasterHubunganKeluarga();
            });

            Task<List<SelectItemList>> t3 = Task<List<SelectItemList>>.Run(() => {
                return getMasterJenisPekerjaan();
            });

            Task<List<SelectItemList>> t4 = Task<List<SelectItemList>>.Run(() => {
                return getMasterPendidikan();
            });

            Task<List<SelectItemList>> t5 = Task<List<SelectItemList>>.Run(() => {
                return getMasterStatusPerkawinan();
            });

            Task.WaitAll(t1,t2,t3,t4,t5);

            //ViewBag Collection
            ViewBag.lsAnggotaKeluarga = ak;
            ViewBag.lsJenisKelamin = jenisKelamins;
            ViewBag.lsKewarganegaraan = kewarganegaraans;
            ViewBag.lsAgama = t1.Result;
            ViewBag.lsHubunganKeluarga = t2.Result;
            ViewBag.lsJenisPekerjaan = t3.Result;
            ViewBag.lsPendidikan = t4.Result;
            ViewBag.lsStatusKawin = t5.Result;
            ViewBag.noKK = NoKK.Trim();
            ViewBag.namaKK = NamaKK.Trim();
            
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

        public async Task<List<SelectItemList>> getMasterAgama()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterAgama> ma = new List<MasterAgama>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterAgama.OrderBy(s => s.OrderNo).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.Agama,
                SelectDisplayMember = item.AgamaDescription});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Agama"});
            
            return selectItemLists;
        }

        public async Task<List<SelectItemList>> getMasterHubunganKeluarga()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterHubunganDalamKeluarga> ma = new List<MasterHubunganDalamKeluarga>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterHubunganDalamKeluarga.OrderBy(x => x.OrderNo).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.HubunganDalamKeluarga,
                SelectDisplayMember = item.HubunganDalamKeluargaDescription});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Hubungan Keluarga"});

            return selectItemLists;
        }

        public async Task<List<SelectItemList>> getMasterJenisPekerjaan()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterJenisPekerjaan> ma = new List<MasterJenisPekerjaan>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterJenisPekerjaan.OrderBy(o => o.OrderNo).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.JenisPekerjaan,
                SelectDisplayMember = item.JenisPekerjaanDescription});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Jenis Pekerjaan"});

            return selectItemLists;
        }

        public async Task<List<SelectItemList>> getMasterPendidikan()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterPendidikan> ma = new List<MasterPendidikan>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterPendidikan.OrderBy(o => o.OrderNo).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.Pendidikan,
                SelectDisplayMember = item.PendidikanDescription});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Pendidikan"});

            return selectItemLists;
        }

        public async Task<List<SelectItemList>> getMasterStatusPerkawinan()
        {
            List<SelectItemList> selectItemLists = new List<SelectItemList>();
            List<MasterStatusPerkawinan> ma = new List<MasterStatusPerkawinan>();

            using (var dataContext = new MyDbContext())
            {
                ma = await dataContext.MasterStatusPerkawinan.OrderBy(o => o.OrderNo).ToListAsync();
            }

            foreach(var item in ma)
            {
                selectItemLists.Add(new SelectItemList{SelectValueMember = item.StatusPerkawinan,
                SelectDisplayMember = item.StatusPerkawinanDescription});
            }

            selectItemLists.Insert(0, new SelectItemList{SelectValueMember = "", 
            SelectDisplayMember = "Pilih Status Perkawinan"});

            return selectItemLists;
        }
    }
}