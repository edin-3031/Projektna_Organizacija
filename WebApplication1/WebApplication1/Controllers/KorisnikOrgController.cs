using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KorisnikOrgController : Controller
    {
        private readonly ApplicationDbContext db;
        public KorisnikOrgController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Prikaz()
        {
            List<Korisnici_OrganizacionaJedinica> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Select(x => new Korisnici_OrganizacionaJedinica
            {
                korisnici=db.Korisnici.Where(c=>c.Korisnici_ID==x.Korisnici_FK).SingleOrDefault(),
                Korisnici_FK=x.Korisnici_FK,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(v=>v.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).SingleOrDefault(),
                OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                Korisnici_OrganizacionaJedinica_ID=x.Korisnici_OrganizacionaJedinica_ID
            }).ToList();

            ViewData["kor_org_jed"]=lista_kor_org;

            return View();
        }
        public IActionResult Unos()
        {
            List<Korisnici> lista_korisnik = db.Korisnici.Select(x => new Korisnici
            {
                Korisnici_ID=x.Korisnici_ID,
                Ime=x.Ime,
                Prezime=x.Prezime
            }).ToList();

            ViewData["korisnik"] = lista_korisnik;

            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            {
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID,
                Naziv=x.Naziv,
            }).ToList();

            ViewData["org_jed"] = lista_org_jed;

            return View();
        }
        public IActionResult UnosSnimi(int korisnik, int organizacionaJedinica)
        {
            Korisnici_OrganizacionaJedinica temp = new Korisnici_OrganizacionaJedinica
            {
                Korisnici_FK = korisnik,
                OrganizacionaJedinica_FK = organizacionaJedinica
            };

            db.Korisnici_OrganizacionaJedinica.Add(temp);
            db.SaveChanges();

            List<Korisnici_OrganizacionaJedinica> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Select(x => new Korisnici_OrganizacionaJedinica
            {
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).SingleOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                organizacionaJedinica = db.OrganizacionaJedinica.Where(v => v.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).SingleOrDefault(),
                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID
            }).ToList();

            ViewData["kor_org_jed"] = lista_kor_org;

            return View("Prikaz");
        }
        public IActionResult Ukloni(int id)
        {
            Korisnici_OrganizacionaJedinica temp = db.Korisnici_OrganizacionaJedinica.Where(v => v.Korisnici_OrganizacionaJedinica_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Korisnici_OrganizacionaJedinica.Remove(temp);
                db.SaveChanges();
            }

            List<Korisnici_OrganizacionaJedinica> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Select(x => new Korisnici_OrganizacionaJedinica
            {
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).SingleOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                organizacionaJedinica = db.OrganizacionaJedinica.Where(v => v.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).SingleOrDefault(),
                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID
            }).ToList();

            ViewData["kor_org_jed"] = lista_kor_org;

            return View("Prikaz");
        }
    }
}
