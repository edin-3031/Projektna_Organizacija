using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class PTTController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";


        public PTTController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Index()
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
        public IActionResult UrediSnimi(int id_ptt, string naziv, int sifra)
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
                PTT t = db.PTT.Where(a => a.PTT_ID == id_ptt).FirstOrDefault();

                t.Naziv = naziv;
                t.Sifra = sifra;

                db.SaveChanges();

                List<PTT> lista_ptt = db.PTT.Select(x => new PTT
                {
                    Naziv = x.Naziv,
                    PTT_ID = x.PTT_ID,
                    Sifra = x.Sifra
                }).ToList();

                ViewData["ptt"] = lista_ptt;

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
                PTT tmp = db.PTT.Where(a => a.PTT_ID == id).FirstOrDefault();

                ViewData["uredi_ptt"] = tmp;

                return View();
            }
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
                List<PTT> lista_ptt = db.PTT.Select(x => new PTT
                {
                    Naziv = x.Naziv,
                    PTT_ID = x.PTT_ID,
                    Sifra = x.Sifra
                }).ToList();

                ViewData["ptt"] = lista_ptt;

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
                PTT temp = new PTT
                {
                    Naziv = naziv,
                    Sifra = sifra
                };

                db.PTT.Add(temp);
                db.SaveChanges();

                List<PTT> lista_ptt = db.PTT.Select(x => new PTT
                {
                    Naziv = x.Naziv,
                    PTT_ID = x.PTT_ID,
                    Sifra = x.Sifra
                }).ToList();

                ViewData["ptt"] = lista_ptt;

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
                PTT temp = db.PTT.Where(x => x.PTT_ID == id).SingleOrDefault();

                if (temp != null)
                {
                    db.PTT.Remove(temp);
                    db.SaveChanges();
                }

                List<PTT> lista_ptt = db.PTT.Select(x => new PTT
                {
                    Naziv = x.Naziv,
                    PTT_ID = x.PTT_ID,
                    Sifra = x.Sifra
                }).ToList();

                ViewData["ptt"] = lista_ptt;
                return View("Prikaz");
            }
        }
    }
}
