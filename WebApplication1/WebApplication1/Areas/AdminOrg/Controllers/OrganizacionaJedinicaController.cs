using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.AdminOrg.Controllers
{
    public class OrganizacionaJedinicaController : Controller
    {
        private readonly ApplicationDbContext db;

        public OrganizacionaJedinicaController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("AdminOrg")]
        public IActionResult Prikaz()
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            List<OrganizacionaJedinicaVM> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Include(a=>a.drzava).Include(a=>a.organizacija).Include(a=>a.ptt).Select(x => new OrganizacionaJedinicaVM
            {
                Adresa=x.Adresa,
                Drzava_id=x.drzava.Drzava_ID,
                Drzava_naziv=x.drzava.Naziv,
                Naziv=x.Naziv,
                Organizacija_id=x.organizacija.Organizacija_ID,
                Organizacija_naziv=x.organizacija.Naziv,
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID,
                PTT_id=x.ptt.PTT_ID,
                PTT_naziv=x.ptt.Naziv
            }).ToList();

            ViewData["org_jed"] = org;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult Unos()
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();


            Organizacija org = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).FirstOrDefault();

            List<PTT> lista_ptt = db.PTT.Select(x => new PTT
            {
                Naziv=x.Naziv,
                Sifra=x.Sifra,
                PTT_ID=x.PTT_ID
            }).ToList();


            List<Drzava> lista_drzava = db.Drzava.Select(x => new Drzava
            {
                Drzava_ID = x.Drzava_ID,
              Sifra=x.Sifra,
              Naziv=x.Naziv
            }).ToList();

            //ViewData["organizacije"] = lista_organizacija;
            ViewData["organizacija"] = org;
            ViewData["ptt"] = lista_ptt;
            ViewData["drzava"] = lista_drzava;

            return View("Unos");
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int organizacija, int ptt, int drzava, string naziv_org_jed, string adresa)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();


            OrganizacionaJedinica temp = new OrganizacionaJedinica
            {
                Adresa = adresa,
                Drzava_FK = drzava,
                Naziv = naziv_org_jed,
                Organizacija_FK = organizacija,
                PTT_FK = ptt,
                organizacija=db.Organizacija.Where(a=>a.Organizacija_ID==organizacija).FirstOrDefault(),
                drzava=db.Drzava.Where(a=>a.Drzava_ID == drzava).FirstOrDefault(),
                ptt=db.PTT.Where(a=>a.PTT_ID==ptt).FirstOrDefault()
            };
            
            db.OrganizacionaJedinica.Add(temp);
            db.SaveChanges();

            Korisnici_OrganizacionaJedinica tmp = new Korisnici_OrganizacionaJedinica
            {
                Korisnici_FK = (int)HttpContext.Session.GetInt32("user ID"),
                OrganizacionaJedinica_FK = temp.OrganizacionaJedinica_ID,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.Organizacija_FK== (int)HttpContext.Session.GetInt32("organisation ID")).FirstOrDefault(),
                korisnici=db.Korisnici.Where(a=>a.Korisnici_ID== (int)HttpContext.Session.GetInt32("user ID")).FirstOrDefault()
            };

            db.Korisnici_OrganizacionaJedinica.Add(tmp);
            db.SaveChanges();


            List<OrganizacionaJedinicaVM> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Include(a => a.drzava).Include(a => a.organizacija).Include(a => a.ptt).Select(x => new OrganizacionaJedinicaVM
            {
                Adresa = x.Adresa,
                Drzava_id = x.drzava.Drzava_ID,
                Drzava_naziv = x.drzava.Naziv,
                Naziv = x.Naziv,
                Organizacija_id = x.organizacija.Organizacija_ID,
                Organizacija_naziv = x.organizacija.Naziv,
                OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                PTT_id = x.ptt.PTT_ID,
                PTT_naziv = x.ptt.Naziv
            }).ToList();

            ViewData["org_jed"] = org;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Ukloni(int id)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();


            OrganizacionaJedinica temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.OrganizacionaJedinica.Remove(temp);
                db.SaveChanges();
            }

            List<OrganizacionaJedinicaVM> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Include(a => a.drzava).Include(a => a.organizacija).Include(a => a.ptt).Select(x => new OrganizacionaJedinicaVM
            {
                Adresa = x.Adresa,
                Drzava_id = x.drzava.Drzava_ID,
                Drzava_naziv = x.drzava.Naziv,
                Naziv = x.Naziv,
                Organizacija_id = x.organizacija.Organizacija_ID,
                Organizacija_naziv = x.organizacija.Naziv,
                OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                PTT_id = x.ptt.PTT_ID,
                PTT_naziv = x.ptt.Naziv
            }).ToList();

            ViewData["org_jed"] = org;

            return View("Prikaz");
        }

        [Area("AdminOrg")]
        public IActionResult Uredi(int id)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            OrganizacionaJedinica o_j = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).FirstOrDefault();
            o_j.organizacija = db.Organizacija.Where(a => a.Organizacija_ID == o_j.Organizacija_FK).FirstOrDefault();
            o_j.drzava = db.Drzava.Where(a => a.Drzava_ID == o_j.Drzava_FK).FirstOrDefault();
            o_j.ptt= db.PTT.Where(a => a.PTT_ID == o_j.PTT_FK).FirstOrDefault();
            ViewData["org_jed"] = o_j;

            List<Drzava> drzave = db.Drzava.ToList();
            ViewData["drzave"] = drzave;

            List<PTT> ptt = db.PTT.ToList();
            ViewData["ptt"] = ptt;

            return View();
        }

        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int id, string adresa, int drzava, string naziv, int organizacija, int ptt)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            OrganizacionaJedinica o_j = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).FirstOrDefault();

            o_j.Adresa = adresa;
            o_j.Drzava_FK = drzava;
            o_j.Naziv = naziv;
            o_j.Organizacija_FK = organizacija;
            o_j.PTT_FK = ptt;

            db.SaveChanges();

            List<OrganizacionaJedinicaVM> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Include(a => a.drzava).Include(a => a.organizacija).Include(a => a.ptt).Select(x => new OrganizacionaJedinicaVM
            {
                Adresa = x.Adresa,
                Drzava_id = x.drzava.Drzava_ID,
                Drzava_naziv = x.drzava.Naziv,
                Naziv = x.Naziv,
                Organizacija_id = x.organizacija.Organizacija_ID,
                Organizacija_naziv = x.organizacija.Naziv,
                OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                PTT_id = x.ptt.PTT_ID,
                PTT_naziv = x.ptt.Naziv
            }).ToList();

            ViewData["org_jed"] = org;

            return View("Prikaz");
        }
    }
}