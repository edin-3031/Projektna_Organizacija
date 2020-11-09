using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class OrganizacionaJedinicaController : Controller
    {
        private readonly ApplicationDbContext db;

        public OrganizacionaJedinicaController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("Admin")]
        public IActionResult Prikaz()
        {
            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            {
                Adresa=x.Adresa,
                drzava=db.Drzava.Where(c=>c.Drazava_ID==x.Drzava_FK).SingleOrDefault(),
                Drzava_FK=x.Drzava_FK,
                Naziv=x.Naziv,
                organizacija=db.Organizacija.Where(v=>v.Organizacija_ID==x.Organizacija_FK).SingleOrDefault(),
                Organizacija_FK=x.Organizacija_FK,
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID,
                ptt=db.PTT.Where(b=>b.PTT_ID==x.PTT_FK).SingleOrDefault(),
                PTT_FK=x.PTT_FK
            }).ToList();

            ViewData["org_jed"] = lista_org_jed;

            return View();
        }
        [Area("Admin")]
        public IActionResult Unos()
        {
            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa=x.Adresa,
                Naziv=x.Naziv,
                Organizacija_ID=x.Organizacija_ID,
                Sifra=x.Sifra
            }).ToList();


            List<PTT> lista_ptt = db.PTT.Select(x => new PTT
            {
                Naziv=x.Naziv,
                Sifra=x.Sifra,
                PTT_ID=x.PTT_ID
            }).ToList();


            List<Drzava> lista_drzava = db.Drzava.Select(x => new Drzava
            { 
              Drazava_ID=x.Drazava_ID,
              Sifra=x.Sifra,
              Naziv=x.Naziv
            }).ToList();

            ViewData["organizacije"] = lista_organizacija;
            ViewData["ptt"] = lista_ptt;
            ViewData["drzava"] = lista_drzava;

            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int organizacija, int ptt, int drzava, string naziv, string adresa)
        {
            OrganizacionaJedinica temp = new OrganizacionaJedinica
            {
                Adresa = adresa,
                Drzava_FK = drzava,
                Naziv = naziv,
                Organizacija_FK = organizacija,
                PTT_FK = ptt
            };

            db.OrganizacionaJedinica.Add(temp);
            db.SaveChanges();

            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            {
                Adresa = x.Adresa,
                drzava = db.Drzava.Where(c => c.Drazava_ID == x.Drzava_FK).SingleOrDefault(),
                Drzava_FK = x.Drzava_FK,
                Naziv = x.Naziv,
                organizacija = db.Organizacija.Where(v => v.Organizacija_ID == x.Organizacija_FK).SingleOrDefault(),
                Organizacija_FK = x.Organizacija_FK,
                OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                ptt = db.PTT.Where(b => b.PTT_ID == x.PTT_FK).SingleOrDefault(),
                PTT_FK = x.PTT_FK
            }).ToList();

            ViewData["org_jed"] = lista_org_jed;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id)
        {
            OrganizacionaJedinica temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.OrganizacionaJedinica.Remove(temp);
                db.SaveChanges();
            }

            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            {
                Adresa = x.Adresa,
                drzava = db.Drzava.Where(c => c.Drazava_ID == x.Drzava_FK).SingleOrDefault(),
                Drzava_FK = x.Drzava_FK,
                Naziv = x.Naziv,
                organizacija = db.Organizacija.Where(v => v.Organizacija_ID == x.Organizacija_FK).SingleOrDefault(),
                Organizacija_FK = x.Organizacija_FK,
                OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                ptt = db.PTT.Where(b => b.PTT_ID == x.PTT_FK).SingleOrDefault(),
                PTT_FK = x.PTT_FK
            }).ToList();

            ViewData["org_jed"] = lista_org_jed;

            return View("Prikaz");
        }
    }
}
