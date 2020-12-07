using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class DrzavaController : Controller
    {
        private readonly ApplicationDbContext db;

        public string poruka="Morate se ponovo prijaviti";

        public DrzavaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id_drzava, string naziv, int sifra)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                Drzava t = db.Drzava.Where(a => a.Drzava_ID == id_drzava).FirstOrDefault();

                t.Naziv = naziv;
                t.Sifra = sifra;

                db.SaveChanges();

                List<Drzava> lista_drzava = db.Drzava.ToList();

                ViewData["drzave"] = lista_drzava;

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
            else
            {

                Drzava tmp = db.Drzava.Where(a => a.Drzava_ID == id).FirstOrDefault();

                ViewData["uredi_drzava"] = tmp;

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
            else
            {
                List<Drzava> lista_drzava = db.Drzava.ToList();

                ViewData["drzave"] = lista_drzava;

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
            else
            {
                Drzava temp = new Drzava
                {
                    Naziv = naziv,
                    Sifra = sifra
                };

                db.Drzava.Add(temp);
                db.SaveChanges();



                List<Drzava> lista_drzava = db.Drzava.ToList();

                ViewData["drzave"] = lista_drzava;


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
            else
            {
                Drzava temp = db.Drzava.Where(x => x.Drzava_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.Drzava.Remove(temp);
                    db.SaveChanges();
                }


                List<Drzava> lista_drzava = db.Drzava.ToList();

                ViewData["drzave"] = lista_drzava;

                return View("Prikaz");
            }
        }
    }
}