using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrganizacijaController : Controller
    {
        private readonly ApplicationDbContext db;

        public OrganizacijaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Ukloni(int id)
        {
            Organizacija temp = db.Organizacija.Where(x => x.Organizacija_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Organizacija.Remove(temp);
                db.SaveChanges();
            }

            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa = x.Adresa,
                Drzava_FK = x.Drzava_FK,
                Naziv = x.Naziv,
                Organizacija_ID = x.Organizacija_ID,
                PTT_FK = x.PTT_FK,
                Sifra = x.Sifra,
                drzava = db.Drzava.Where(c => c.Drazava_ID == x.Drzava_FK).FirstOrDefault(),
                ptt = db.PTT.Where(v => v.PTT_ID == x.PTT_FK).FirstOrDefault()
            }).ToList();

            ViewData["organizacija"] = lista_organizacija;

            return View("Prikaz");
        }

        public IActionResult UnosSnimi(int ptt, int drzava, int sifra, string naziv, string adresa)
        {

            Organizacija temp = new Organizacija
            {
                Adresa = adresa,
                Drzava_FK = drzava,
                Naziv = naziv,
                PTT_FK = ptt,
                Sifra = sifra
            };

            db.Organizacija.Add(temp);

            db.SaveChanges();

            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa = x.Adresa,
                Drzava_FK = x.Drzava_FK,
                Naziv = x.Naziv,
                Organizacija_ID = x.Organizacija_ID,
                PTT_FK = x.PTT_FK,
                Sifra = x.Sifra,
                drzava = db.Drzava.Where(c => c.Drazava_ID == x.Drzava_FK).FirstOrDefault(),
                ptt = db.PTT.Where(v => v.PTT_ID == x.PTT_FK).FirstOrDefault()
            }).ToList();

            ViewData["organizacija"] = lista_organizacija;
            return View("Prikaz");
        }

        public IActionResult Unos() {

            List<PTT> lista_ptt = db.PTT.Select(y => new PTT
            {
                Naziv = y.Naziv,
                PTT_ID = y.PTT_ID,
                Sifra = y.Sifra
            }).ToList();

            List<Drzava> lista_drzava = db.Drzava.Select(z => new Drzava
            {
                Drazava_ID = z.Drazava_ID,
                Sifra = z.Sifra,
                Naziv = z.Naziv
            }).ToList();

            ViewData["ptt"] = lista_ptt;
            ViewData["drzava"] = lista_drzava;

            return View("Unos");
        }

        public IActionResult Prikaz()
        {
            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa=x.Adresa,
                Drzava_FK=x.Drzava_FK,
                Naziv=x.Naziv,
                Organizacija_ID=x.Organizacija_ID,
                PTT_FK=x.PTT_FK,
                Sifra=x.Sifra,
                drzava=db.Drzava.Where(c=>c.Drazava_ID==x.Drzava_FK).FirstOrDefault(),
                ptt=db.PTT.Where(v=>v.PTT_ID==x.PTT_FK).FirstOrDefault()
            }).ToList();

            ViewData["organizacija"] = lista_organizacija;

            return View("Prikaz");
        }
    }
}
