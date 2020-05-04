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
            return View();
        }
    }
}