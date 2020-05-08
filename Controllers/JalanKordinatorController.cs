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
    public class JalanKordinatorController : Controller
    {
        private readonly ILogger<JalanKordinatorController> _logger;
        public JalanKordinatorController(ILogger<JalanKordinatorController> logger)
        {
            _logger = logger;
        }

        public ActionResult FecthJalanKordinator()
        {
            List<VwKordinatorJalan> vkj = new List<VwKordinatorJalan>();

            Task<List<MasterJalan>> t1 = Task<List<MasterJalan>>.Run(() => {
                return GetMasterJalan();
            });

            Task<List<KordinatorJalan>> t2 = Task<List<KordinatorJalan>>.Run(() => {
                return GetKordinatorJalan();
            });

            Task<List<AnggotaKeluarga>> t3 = Task<List<AnggotaKeluarga>>.Run(() => {
                return GetAnggotaKeluarga();
            });

            Task<List<MasterBlokNoRumah>> t4 = Task<List<MasterBlokNoRumah>>.Run(() => {
                return GetMasterBlokNoRumah();
            });

            Task<List<AlamatKK>> t5 = Task<List<AlamatKK>>.Run(() => {
                return GetAlamatKK();
            });

            Task.WaitAll(t1,t2,t3,t4,t5);

            var vwKorJln = (from mj in t1.Result
                join kj in t2.Result 
                on mj.JalanId equals kj.JalanId
                join ak in t3.Result
                on kj.NIK equals ak.Nik
                into mjkjak
                from subJoin in mjkjak.DefaultIfEmpty()
                select new {
                    mj.JalanId,
                    mj.NamaJalan,
                    NamaKordinator = subJoin?.NamaLengkap ?? string.Empty,
                    kj.MasaJabatan,
                    TotalUnit = (from mbr in t4.Result
                        .Where(x => x.JalanId == mj.JalanId)
                        select mbr).ToList().Count, 
                    UnitTerisi = (from akk in t5.Result
                        join mbr in t4.Result
                        on akk.BlokNoRumah equals mbr.BlokNoRumah
                        into akkmbr
                        select akkmbr
                        .Where(x => x.JalanId == mj.JalanId)
                        ).ToList().Count,
                    HuniTetap = (from akk in t5.Result
                        join mbr in t4.Result
                        on akk.BlokNoRumah equals mbr.BlokNoRumah
                        into akkmbr
                        from xakkmbr in akkmbr
                        select new {
                            akk.StatusHuniId,
                            akk.BlokNoRumah,
                            JalanId = xakkmbr.JalanId
                        }
                        ).Where(x => x.JalanId == mj.JalanId && x.StatusHuniId == "TTP")

                }     
            );


            return View();
        }

        public async Task<List<MasterJalan>> GetMasterJalan()
        {
            List<MasterJalan> mj = new List<MasterJalan>();
            using (var dataContext = new MyDbContext())
            {
                mj = await dataContext.MasterJalan.ToListAsync();
            }
            return mj;
        }

        public async Task<List<KordinatorJalan>> GetKordinatorJalan()
        {
            List<KordinatorJalan> kj = new List<KordinatorJalan>();
            using (var dataContext = new MyDbContext())
            {
                kj = await dataContext.KordinatorJalan.ToListAsync();
            }
            return kj;
        }

        public async Task<List<AnggotaKeluarga>> GetAnggotaKeluarga()
        {
            List<AnggotaKeluarga> ak = new List<AnggotaKeluarga>();
            using (var dataContext = new MyDbContext())
            {
                ak = await dataContext.AnggotaKeluarga.ToListAsync();
            }
            return ak;
        }

        public async Task<List<MasterBlokNoRumah>> GetMasterBlokNoRumah()
        {
            List<MasterBlokNoRumah> mbr = new List<MasterBlokNoRumah>();
            using (var dataContext = new MyDbContext())
            {
                mbr = await dataContext.MasterBlokNoRumah.ToListAsync();
            }
            return mbr;
        }

        public async Task<List<AlamatKK>> GetAlamatKK()
        {
            List<AlamatKK> akk = new List<AlamatKK>();
            using (var dataContext = new MyDbContext())
            {
                akk = await dataContext.AlamatKK.ToListAsync();
            }
            return akk;
        }
    }
}