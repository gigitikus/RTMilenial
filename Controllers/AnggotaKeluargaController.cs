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

        public AnggotaKeluargaController(ILogger<AnggotaKeluargaController> logger)
        {
            _logger = logger;
        } 
    }
}