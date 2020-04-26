﻿using System;
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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Task<int> t1 = Task<int>.Run(() => {
                return getCountKK();
            });

            Task<int> t2 = Task<int>.Run(() => {
                return getCountAngKK();
            });

            Task<List<AnggotaKeluarga>> t3 = Task<List<AnggotaKeluarga>>.Run(() => {
                return GetAnggotaKeluargas();
            });

            Task.WaitAll(t1,t2, t3);

            var tcountAnak = (from ca in t3.Result
                            select new {
                                Age = DateTime.Now.Year - ca.TanggalLahir.Year
                            }).ToList();

            int CountAnak = (from c in tcountAnak
                            .Where(x => x.Age >= 5 && x.Age < 12)
                            select c).ToList().Count;          


            ViewBag.CountKK = t1.Result;
            ViewBag.CountAngKK = t2.Result;
            ViewBag.TotalWarga = t1.Result + t2.Result;
            ViewBag.CountAnak = CountAnak;

            return View();
        }

        public async Task<List<AnggotaKeluarga>> GetAnggotaKeluargas()
        {
            List<AnggotaKeluarga> ak = new List<AnggotaKeluarga>();
            using (var dataContext = new MyDbContext())
            {
                ak = await dataContext.AnggotaKeluarga.ToListAsync();
            }
            return ak;
        }
        public async Task<int> getCountKK()
        {
            int result = 0;
            using (var dataContext = new MyDbContext())
            {
                List<KepalaKeluarga> kk = await dataContext.KepalaKeluarga.ToListAsync();
                result = kk.Count;
            }
            return result;
        }

        public async Task<int> getCountAngKK()
        {
            int result = 0;
            using (var dataContext = new MyDbContext())
            {
                List<AnggotaKeluarga> kk = await dataContext.AnggotaKeluarga.Where(x => x.HubunganDalamKeluarga != "KEPALA KELUARGA").ToListAsync();
                result = kk.Count;
            }
            return result;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
