using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

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
        public IActionResult Prikaz(int u, int o, int r)
        {
            OrganizacionaJedinica org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).FirstOrDefault();

            //List<Korisnici_OrganizacionaJedinica> k_oj = db.Korisnici_OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_FK == org_jed.OrganizacionaJedinica_ID).Select(c => new Korisnici_OrganizacionaJedinica
            //{
            //    Korisnici_FK = c.Korisnici_FK
            //}).ToList();

            //List<Korisnici> lista_korisnici = new List<Korisnici>();

            //foreach (var x in k_oj)
            //{
            //    lista_korisnici.Add(new Korisnici
            //    {
            //        Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
            //        Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
            //        Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
            //        Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
            //        Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
            //        Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
            //        Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
            //        Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
            //        Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
            //        uloge=db.Uloge.Where(a=>a.Uloge_ID==(db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
            //    });
            //}

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            List<Korisnici> lista_korisnici = db.Korisnici.ToList();

            foreach(var x  in lista_korisnici)
            {
                x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
            };

            ViewData["korisnik"] = lista_korisnici;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Unos(int u, int o, int r)
        {
            List<Uloge> lista_uloge = db.Uloge.Select(x => new Uloge
            {
                Naziv=x.Naziv,
                Opis=x.Opis,
                Sifra=x.Sifra,
                Uloge_ID=x.Uloge_ID
            }).ToList();

            ViewData["uloge"] = lista_uloge;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int uloga, int sifra, string ime, string prezime, string telefon, string mail, string lozinka, string username, int u, int o, int r)
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

            //OrganizacionaJedinica org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).FirstOrDefault();

            //List<Korisnici_OrganizacionaJedinica> k_oj = db.Korisnici_OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_FK == org_jed.OrganizacionaJedinica_ID).Select(c => new Korisnici_OrganizacionaJedinica
            //{
            //    Korisnici_FK = c.Korisnici_FK
            //}).ToList();

            //List<Korisnici> lista_korisnici = new List<Korisnici>();

            //foreach (var x in k_oj)
            //{
            //    lista_korisnici.Add(new Korisnici
            //    {
            //        Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
            //        Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
            //        Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
            //        Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
            //        Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
            //        Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
            //        Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
            //        Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
            //        Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
            //        uloge= db.Uloge.Where(a => a.Uloge_ID == (db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
            //    });
            //}

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            List<Korisnici> lista_korisnici = db.Korisnici.ToList();

            foreach (var x in lista_korisnici)
            {
                x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
            };

            ViewData["id"] = podaci;

            ViewData["korisnik"] = lista_korisnici;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            Korisnici tmp = db.Korisnici.Where(x => x.Korisnici_ID == id).SingleOrDefault();

            if (tmp != null)
            {
                db.Korisnici.Remove(tmp);
                db.SaveChanges();
            }

            //OrganizacionaJedinica org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).FirstOrDefault();

            //List<Korisnici_OrganizacionaJedinica> k_oj = db.Korisnici_OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_FK == org_jed.OrganizacionaJedinica_ID).Select(c => new Korisnici_OrganizacionaJedinica
            //{
            //    Korisnici_FK = c.Korisnici_FK
            //}).ToList();

            //List<Korisnici> lista_korisnici = new List<Korisnici>();

            //foreach (var x in k_oj)
            //{
            //    lista_korisnici.Add(new Korisnici
            //    {
            //        Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
            //        Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
            //        Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
            //        Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
            //        Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
            //        Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
            //        Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
            //        Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
            //        Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
            //        uloge= db.Uloge.Where(a => a.Uloge_ID == (db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
            //    });
            //}

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            List<Korisnici> lista_korisnici = db.Korisnici.ToList();

            foreach (var x in lista_korisnici)
            {
                x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
            };

            ViewData["id"] = podaci;

            ViewData["korisnik"] = lista_korisnici;
            return View("Prikaz");
        }
    }
}