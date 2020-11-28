using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

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
        public IActionResult Prikaz(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            List<OrganizacionaJedinica> lista_org_jed = new List<OrganizacionaJedinica>();

            List<OrganizacionaJedinica> org = db.OrganizacionaJedinica.Where(a=>a.Organizacija_FK==o).ToList();

            foreach(var x in org)
            {
                if (x.Organizacija_FK == o)
                {
                    lista_org_jed.Add(new OrganizacionaJedinica
                    {
                        Adresa=x.Adresa,
                        drzava=db.Drzava.Where(a=>a.Drzava_ID == x.Drzava_FK).FirstOrDefault(),
                        Drzava_FK=x.Drzava_FK,
                        Naziv=db.OrganizacionaJedinica.Where(a=>a.Organizacija_FK==o).Select(p=>p.Naziv).FirstOrDefault(),
                        organizacija=db.Organizacija.Where(a=>a.Organizacija_ID==o).FirstOrDefault(),
                        Organizacija_FK=x.Organizacija_FK,
                        OrganizacionaJedinica_ID= db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.OrganizacionaJedinica_ID).FirstOrDefault(),
                        ptt=db.PTT.Where(a=>a.PTT_ID==x.PTT_FK).FirstOrDefault(),
                        PTT_FK= db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(p=>p.PTT_ID).FirstOrDefault()
                    });
                }
            }

            ViewData["org_jed"] = org;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult Unos(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            //List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            //{
            //    Adresa=x.Adresa,
            //    Naziv=x.Naziv,
            //    Organizacija_ID=x.Organizacija_ID,
            //    Sifra=x.Sifra
            //}).ToList();

            Organizacija org = db.Organizacija.Where(a => a.Organizacija_ID == o).FirstOrDefault();

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

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Unos");
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int organizacija, int ptt, int drzava, string naziv_org_jed, string adresa, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

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
                Korisnici_FK = u,
                OrganizacionaJedinica_FK = temp.OrganizacionaJedinica_ID,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.Organizacija_FK==o).FirstOrDefault(),
                korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==u).FirstOrDefault()
            };

            db.Korisnici_OrganizacionaJedinica.Add(tmp);
            db.SaveChanges();


            //List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            //{
            //    Adresa = x.Adresa,
            //    drzava = db.Drzava.Where(c => c.Drzava_ID == x.Drzava_FK).SingleOrDefault(),
            //    Drzava_FK = x.Drzava_FK,
            //    Naziv = x.Naziv,
            //    organizacija = db.Organizacija.Where(v => v.Organizacija_ID == x.Organizacija_FK).SingleOrDefault(),
            //    Organizacija_FK = x.Organizacija_FK,
            //    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
            //    ptt = db.PTT.Where(b => b.PTT_ID == x.PTT_FK).SingleOrDefault(),
            //    PTT_FK = x.PTT_FK
            //}).ToList();


            List<OrganizacionaJedinica> lista_org_jed = new List<OrganizacionaJedinica>();

            List<OrganizacionaJedinica> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            foreach (var x in org)
            {
                if (x.Organizacija_FK == o)
                {
                    lista_org_jed.Add(new OrganizacionaJedinica
                    {
                        Adresa = x.Adresa,
                        drzava = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).FirstOrDefault(),
                        Drzava_FK = x.Drzava_FK,
                        Naziv = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.Naziv).FirstOrDefault(),
                        organizacija = db.Organizacija.Where(a => a.Organizacija_ID == o).FirstOrDefault(),
                        Organizacija_FK = x.Organizacija_FK,
                        OrganizacionaJedinica_ID = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.OrganizacionaJedinica_ID).FirstOrDefault(),
                        ptt = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).FirstOrDefault(),
                        PTT_FK = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(p => p.PTT_ID).FirstOrDefault()
                    });
                }
            }

            ViewData["org_jed"] = org;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            OrganizacionaJedinica temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.OrganizacionaJedinica.Remove(temp);
                db.SaveChanges();
            }

            //List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            //{
            //    Adresa = x.Adresa,
            //    drzava = db.Drzava.Where(c => c.Drzava_ID == x.Drzava_FK).SingleOrDefault(),
            //    Drzava_FK = x.Drzava_FK,
            //    Naziv = x.Naziv,
            //    organizacija = db.Organizacija.Where(v => v.Organizacija_ID == x.Organizacija_FK).SingleOrDefault(),
            //    Organizacija_FK = x.Organizacija_FK,
            //    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
            //    ptt = db.PTT.Where(b => b.PTT_ID == x.PTT_FK).SingleOrDefault(),
            //    PTT_FK = x.PTT_FK
            //}).ToList();


            List<OrganizacionaJedinica> lista_org_jed = new List<OrganizacionaJedinica>();

            List<OrganizacionaJedinica> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            foreach (var x in org)
            {
                if (x.Organizacija_FK == o)
                {
                    lista_org_jed.Add(new OrganizacionaJedinica
                    {
                        Adresa = x.Adresa,
                        drzava = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).FirstOrDefault(),
                        Drzava_FK = x.Drzava_FK,
                        Naziv = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.Naziv).FirstOrDefault(),
                        organizacija = db.Organizacija.Where(a => a.Organizacija_ID == o).FirstOrDefault(),
                        Organizacija_FK = x.Organizacija_FK,
                        OrganizacionaJedinica_ID = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.OrganizacionaJedinica_ID).FirstOrDefault(),
                        ptt = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).FirstOrDefault(),
                        PTT_FK = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(p => p.PTT_ID).FirstOrDefault()
                    });
                }
            }

            ViewData["org_jed"] = org;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }

        [Area("AdminOrg")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            OrganizacionaJedinica o_j = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).FirstOrDefault();
            o_j.organizacija = db.Organizacija.Where(a => a.Organizacija_ID == o_j.Organizacija_FK).FirstOrDefault();
            o_j.drzava = db.Drzava.Where(a => a.Drzava_ID == o_j.Drzava_FK).FirstOrDefault();
            o_j.ptt= db.PTT.Where(a => a.PTT_ID == o_j.PTT_FK).FirstOrDefault();
            ViewData["org_jed"] = o_j;

            List<Drzava> drzave = db.Drzava.ToList();
            ViewData["drzave"] = drzave;

            List<PTT> ptt = db.PTT.ToList();
            ViewData["ptt"] = ptt;

            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }

        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int id, int u, int o, int r, string adresa, int drzava, string naziv, int organizacija, int ptt)
        {
            OrganizacionaJedinica o_j = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).FirstOrDefault();

            o_j.Adresa = adresa;
            o_j.Drzava_FK = drzava;
            o_j.Naziv = naziv;
            o_j.Organizacija_FK = organizacija;
            o_j.PTT_FK = ptt;

            db.SaveChanges();

            List<OrganizacionaJedinica> lista_org_jed = new List<OrganizacionaJedinica>();

            List<OrganizacionaJedinica> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            foreach (var x in org)
            {
                if (x.Organizacija_FK == o)
                {
                    lista_org_jed.Add(new OrganizacionaJedinica
                    {
                        Adresa = x.Adresa,
                        drzava = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).FirstOrDefault(),
                        Drzava_FK = x.Drzava_FK,
                        Naziv = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.Naziv).FirstOrDefault(),
                        organizacija = db.Organizacija.Where(a => a.Organizacija_ID == o).FirstOrDefault(),
                        Organizacija_FK = x.Organizacija_FK,
                        OrganizacionaJedinica_ID = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(p => p.OrganizacionaJedinica_ID).FirstOrDefault(),
                        ptt = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).FirstOrDefault(),
                        PTT_FK = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(p => p.PTT_ID).FirstOrDefault()
                    });
                }
            }

            ViewData["org_jed"] = org;

            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

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
