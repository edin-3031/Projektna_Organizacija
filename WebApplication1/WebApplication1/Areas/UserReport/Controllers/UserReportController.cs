using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.UserReport.Controllers
{
    public class UserReportController : Controller
    {
        private readonly ApplicationDbContext db;

        public UserReportController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("UserReport")]
        public IActionResult Index(int u, int o, int r)
        {
            ViewData["slika"] = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Slika).FirstOrDefault();

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;
            return View(podaci);
        }

    }
}
