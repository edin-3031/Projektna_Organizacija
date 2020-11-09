using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly ApplicationDbContext db;

        public KorisnikController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("Admin")]
        public IActionResult Prikaz()
        {
            List<Korisnici> lista_korisnici = db.Korisnici.Select(x => new Korisnici
            {
                Ime = x.Ime,
                Korisnici_ID = x.Korisnici_ID,
                Lozinka = x.Lozinka,
                Mail = x.Mail,
                Prezime = x.Prezime,
                Sifra = x.Sifra,
                Telefon = x.Telefon,
                uloge = db.Uloge.Where(c => c.Uloge_ID == x.Uloge_FK).SingleOrDefault(),
                Uloge_FK = x.Uloge_FK,
                Korisnicko_Ime=x.Korisnicko_Ime
            }).ToList();

            ViewData["korisnik"] = lista_korisnici;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Unos()
        {
            List<Uloge> lista_uloge = db.Uloge.Select(x => new Uloge
            {
                Naziv=x.Naziv,
                Opis=x.Opis,
                Sifra=x.Sifra,
                Uloge_ID=x.Uloge_ID
            }).ToList();

            ViewData["uloge"] = lista_uloge;

            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int uloga, int sifra, string ime, string prezime, string telefon, string mail, string lozinka, string username)
        {
            Korisnici temp = new Korisnici
            {
                Ime = ime,
                Sifra = sifra,
                Lozinka = lozinka,
                Mail = mail,
                Prezime = prezime,
                Telefon = telefon,
                Uloge_FK = uloga,
                Korisnicko_Ime=username
            };

            db.Korisnici.Add(temp);
            db.SaveChanges();

            List<Korisnici> lista_korisnici = db.Korisnici.Select(x => new Korisnici
            {
                Ime = x.Ime,
                Korisnici_ID = x.Korisnici_ID,
                Lozinka = x.Lozinka,
                Mail = x.Mail,
                Prezime = x.Prezime,
                Sifra = x.Sifra,
                Telefon = x.Telefon,
                uloge = db.Uloge.Where(c => c.Uloge_ID == x.Uloge_FK).SingleOrDefault(),
                Uloge_FK = x.Uloge_FK
            }).ToList();

            ViewData["korisnik"] = lista_korisnici;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id)
        {
            Korisnici tmp = db.Korisnici.Where(x => x.Korisnici_ID == id).SingleOrDefault();

            if (tmp != null)
            {
                db.Korisnici.Remove(tmp);
                db.SaveChanges();
            }

            List<Korisnici> lista_korisnici = db.Korisnici.Select(x => new Korisnici
            {
                Ime = x.Ime,
                Korisnici_ID = x.Korisnici_ID,
                Lozinka = x.Lozinka,
                Mail = x.Mail,
                Prezime = x.Prezime,
                Sifra = x.Sifra,
                Telefon = x.Telefon,
                uloge = db.Uloge.Where(c => c.Uloge_ID == x.Uloge_FK).SingleOrDefault(),
                Uloge_FK = x.Uloge_FK
            }).ToList();

            ViewData["korisnik"] = lista_korisnici;
            return View("Prikaz");
        }
    }
}
