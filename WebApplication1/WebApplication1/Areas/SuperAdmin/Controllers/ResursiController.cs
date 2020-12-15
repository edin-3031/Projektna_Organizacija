using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class ResursiController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";

        public ResursiController(ApplicationDbContext _db)
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
                List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
                {
                    Naziv = x.Naziv,
                    Resursi_ID = x.Resursi_ID
                }).ToList();

                ViewData["resursi"] = lista_resursa;

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
                Resursi temp = db.Resursi.Where(x => x.Resursi_ID == id).SingleOrDefault();

                if (temp != null)
                {
                    db.Resursi.Remove(temp);
                    db.SaveChanges();
                }

                List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
                {
                    Naziv = x.Naziv,
                    Resursi_ID = x.Resursi_ID
                }).ToList();

                ViewData["resursi"] = lista_resursa;

                return View("Prikaz");
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
                return View("Unos");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(string naziv)
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
                Resursi temp = new Resursi
                {
                    Naziv = naziv
                };

                if (temp != null)
                {
                    db.Resursi.Add(temp);
                    db.SaveChanges();
                }

                List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
                {
                    Naziv = x.Naziv,
                    Resursi_ID = x.Resursi_ID
                }).ToList();

                ViewData["resursi"] = lista_resursa;

                return View("Prikaz");
            }
        }
    }
}
