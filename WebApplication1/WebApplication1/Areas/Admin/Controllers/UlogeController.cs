using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

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
        public IActionResult Obrisi(int id)
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

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Prikaz()
        {
            List<Uloge> lista_uloga = db.Uloge.Select(x=>new Uloge
            {
                Naziv=x.Naziv,
                Opis=x.Opis,
                Sifra=x.Sifra,
                Uloge_ID=x.Uloge_ID
            }).ToList();

            ViewData["prikazUloga"] = lista_uloga;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Unos()
        {
            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int sifra, string naziv, string opis)
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

            return View("Prikaz");
        }
    }
}
