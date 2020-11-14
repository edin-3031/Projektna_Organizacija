using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class UlogeController : Controller
    {
        private readonly ApplicationDbContext db;

        public UlogeController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("Admin")]
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
        [Area("Admin")]
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
        [Area("Admin")]
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
        [Area("Admin")]
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
    }
}
