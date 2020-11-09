using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class DrzavaController : Controller
    {
        private readonly ApplicationDbContext db;

        public DrzavaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("Admin")]
        public IActionResult Prikaz()
        {
            List<Drzava> lista_drzava = db.Drzava.Select(x => new Drzava
            {
                Drazava_ID=x.Drazava_ID,
                Naziv=x.Naziv,
                Sifra=x.Sifra
            }).ToList();

            ViewData["drzave"] = lista_drzava;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Unos()
        {
            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int sifra, string naziv)
        {
            Drzava temp = new Drzava
            {
                Naziv = naziv,
                Sifra = sifra
            };

            db.Drzava.Add(temp);
            db.SaveChanges();

            List<Drzava> lista_drzava = db.Drzava.Select(x => new Drzava
            {
                Drazava_ID = x.Drazava_ID,
                Naziv = x.Naziv,
                Sifra = x.Sifra
            }).ToList();

            ViewData["drzave"] = lista_drzava;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id)
        {
            Drzava temp = db.Drzava.Where(x => x.Drazava_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Drzava.Remove(temp);
                db.SaveChanges();
            }

            List<Drzava> lista_drzava = db.Drzava.Select(x => new Drzava
            {
                Drazava_ID = x.Drazava_ID,
                Naziv = x.Naziv,
                Sifra = x.Sifra
            }).ToList();

            ViewData["drzave"] = lista_drzava;

            return View("Prikaz");
        }
    }
}
