using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class StatusController : Controller
    {
        private readonly ApplicationDbContext db;

        public StatusController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<Status> s = db.Status.ToList();
            ViewData["status"] = s;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }

        [Area("SuperAdmin")]
        public IActionResult Unos(int u, int o, int r)
        {
            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }

        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int sifra, string naziv, int u, int o, int r)
        {
            Status s_temp = new Status
            {
                Naziv = naziv,
                Sifra = sifra
            };

            db.Status.Add(s_temp);
            db.SaveChanges();

            List<Status> s = db.Status.ToList();
            ViewData["status"] = s;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }

        [Area("SuperAdmin")]
        public IActionResult Uredi(int u, int o, int r, int id)
        {
            Status s_temp = db.Status.Where(a => a.StatusID == id).FirstOrDefault();

            ViewData["status"] = s_temp;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, int u, int o, int r, string naziv, int sifra)
        {
            Status s_temp = db.Status.Where(a => a.StatusID == id).FirstOrDefault();

            s_temp.Naziv = naziv;
            s_temp.Sifra = sifra;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            db.SaveChanges();

            List<Status> s = db.Status.ToList();
            ViewData["status"] = s;

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("SuperAdmin")]
        public IActionResult Ukloni(int u, int o, int r, int id)
        {
            Status s_temp = db.Status.Where(a => a.StatusID == id).FirstOrDefault();

            if (s_temp != null)
            {
                db.Remove(s_temp);
                db.SaveChanges();
            }

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            List<Status> s = db.Status.ToList();
            ViewData["status"] = s;

            return View("Prikaz");
        }
    }
}