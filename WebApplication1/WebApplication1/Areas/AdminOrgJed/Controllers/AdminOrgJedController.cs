using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.AdminOrgJed.Controllers
{
    public class AdminOrgJedController : Controller
    {
        private readonly ApplicationDbContext db;

        public AdminOrgJedController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("AdminOrgJed")]
        public IActionResult Index(int u, int o, int r)
        {

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            ViewData["slika"] = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Slika).FirstOrDefault();

            return View();
        }
    }
}