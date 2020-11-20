using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class UlogeController : Controller
    {
        private readonly ApplicationDbContext db;

        public UlogeController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("SuperAdmin")]
        public IActionResult Obrisi(int id, int u, int o, int r)
        {
            Uloge temp = db.Uloge.Where(a => a.Uloge_ID == id).SingleOrDefault();

            if(temp!=null)
            {
                db.Uloge.Remove(temp);
                db.SaveChanges();
            }

            List<Uloge> lista_uloga = db.Uloge.Select(x => new Uloge
            {
                Naziv = x.Naziv,
                Opis = x.Opis,
                Sifra = x.Sifra,
                Uloge_ID = x.Uloge_ID
            }).ToList();

            ViewData["prikazUloga"] = lista_uloga;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("SuperAdmin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<Uloge> lista_uloga = db.Uloge.Select(x=>new Uloge
            {
                Naziv=x.Naziv,
                Opis=x.Opis,
                Sifra=x.Sifra,
                Uloge_ID=x.Uloge_ID
            }).ToList();

            ViewData["prikazUloga"] = lista_uloga;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("SuperAdmin")]
        public IActionResult Unos(int u, int o, int r)
        {
            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Unos");
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int u, int o, int r, int sifra, string naziv, string opis)
        {
            Uloge tmp = new Uloge
            {
                Naziv = naziv,
                Opis = opis,
                Sifra = sifra
            };

            db.Uloge.Add(tmp);

            db.SaveChanges();

            List<Uloge> lista_uloga = db.Uloge.Select(x => new Uloge
            {
                Naziv = x.Naziv,
                Opis = x.Opis,
                Sifra = x.Sifra,
                Uloge_ID = x.Uloge_ID
            }).ToList();

            ViewData["prikazUloga"] = lista_uloga;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }

        [Area("SuperAdmin")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            Uloge uloga = db.Uloge.Where(a => a.Uloge_ID == id).FirstOrDefault();

            ViewData["uloga"] = uloga;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, int u, int o, int r, int sifra, string opis, string naziv)
        {
            Uloge t= db.Uloge.Where(a => a.Uloge_ID == id).FirstOrDefault();

            t.Naziv = naziv;
            t.Opis = opis;
            t.Sifra = sifra;

            db.SaveChanges();

            List<Uloge> lista_uloga = db.Uloge.Select(x => new Uloge
            {
                Naziv = x.Naziv,
                Opis = x.Opis,
                Sifra = x.Sifra,
                Uloge_ID = x.Uloge_ID
            }).ToList();

            ViewData["prikazUloga"] = lista_uloga;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
    }
}
