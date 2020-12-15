using Microsoft.AspNetCore.Http;
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
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";

        public StatusController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }

            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<Status> s = db.Status.ToList();
                ViewData["status"] = s;

                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult Unos()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int sifra, string naziv)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
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

                return View("Prikaz");
            }
        }

        [Area("SuperAdmin")]
        public IActionResult Uredi(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Status s_temp = db.Status.Where(a => a.StatusID == id).FirstOrDefault();

                ViewData["status"] = s_temp;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, string naziv, int sifra)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Status s_temp = db.Status.Where(a => a.StatusID == id).FirstOrDefault();

                s_temp.Naziv = naziv;
                s_temp.Sifra = sifra;

                db.SaveChanges();

                List<Status> s = db.Status.ToList();
                ViewData["status"] = s;

                return View("Prikaz");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Ukloni(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Status s_temp = db.Status.Where(a => a.StatusID == id).FirstOrDefault();

                if (s_temp != null)
                {
                    db.Remove(s_temp);
                    db.SaveChanges();
                }

                List<Status> s = db.Status.ToList();
                ViewData["status"] = s;

                return View("Prikaz");
            }
        }
    }
}