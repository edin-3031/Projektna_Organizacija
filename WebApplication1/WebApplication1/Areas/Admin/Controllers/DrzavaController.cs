using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class DrzavaController : Controller
    {
        private readonly ApplicationDbContext db;

        public DrzavaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public uor podaci;

        [Area("Admin")]
        public IActionResult UrediSnimi(int id_drzava, int u, int o, int r, string naziv, int sifra)
        {
            uor model = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            Drzava t = db.Drzava.Where(a => a.Drazava_ID == id_drzava).FirstOrDefault();

            t.Naziv = naziv;
            t.Sifra = sifra;

            db.SaveChanges();

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;

            return View("Prikaz",model);
        }

        [Area("Admin")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            ViewData["id"] = podaci;

            Drzava tmp = db.Drzava.Where(a => a.Drazava_ID == id).FirstOrDefault();

            ViewData["uredi_drzava"] = tmp;

            return View();
        }

        [Area("Admin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            //List<OrganizacionaJedinica> lista_oj = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(x => new OrganizacionaJedinica
            //{
            //    drzava=db.Drzava.Where(p=>p.Drazava_ID==x.Drzava_FK).FirstOrDefault()
            //}).ToList();

            //List<Drzava> lista_drzava = new List<Drzava>();

            //foreach(var x in lista_oj)
            //{
            //    lista_drzava.Add(new Drzava
            //    {
            //        Drazava_ID=x.drzava.Drazava_ID,
            //        Naziv=x.drzava.Naziv,
            //        Sifra=x.drzava.Sifra
            //    });
            //}

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;

            return View(podaci);
        }



        [Area("Admin")]
        public IActionResult Unos(int u, int o, int r)
        {
            podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            ViewData["id"] = podaci;

            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int u, int o, int r,int sifra, string naziv)
        {
            Drzava temp = new Drzava
            {
                Naziv = naziv,
                Sifra = sifra
            };

            db.Drzava.Add(temp);
            db.SaveChanges();

            uor podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            //List<OrganizacionaJedinica> lista_oj = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(x => new OrganizacionaJedinica
            //{
            //    Drzava_FK=x.Drzava_FK
            //}).ToList();

            //List<Drzava> lista_drzava = new List<Drzava>();

            //foreach (var x in lista_oj)
            //{
            //    lista_drzava.Add(new Drzava
            //    {
            //        Drazava_ID = db.Drzava.Where(a=>a.Drazava_ID==x.Drzava_FK).Select(o=>o.Drazava_ID).FirstOrDefault(),
            //        Naziv = db.Drzava.Where(a => a.Drazava_ID == x.Drzava_FK).Select(o => o.Naziv).FirstOrDefault(),
            //        Sifra = db.Drzava.Where(a => a.Drazava_ID == x.Drzava_FK).Select(o => o.Sifra).FirstOrDefault()
            //    });
            //}
            //ViewData["drzave"] = lista_drzava;

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;


            return View("Prikaz",podaci);
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            Drzava temp = db.Drzava.Where(x => x.Drazava_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Drzava.Remove(temp);
                db.SaveChanges();
            }

            podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            //List<OrganizacionaJedinica> lista_oj = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).Select(x => new OrganizacionaJedinica
            //{
            //    drzava = db.Drzava.Where(p => p.Drazava_ID == x.Drzava_FK).FirstOrDefault()
            //}).ToList();

            //List<Drzava> lista_drzava = new List<Drzava>();

            //foreach (var x in lista_oj)
            //{
            //    lista_drzava.Add(new Drzava
            //    {
            //        Drazava_ID = x.drzava.Drazava_ID,
            //        Naziv = x.drzava.Naziv,
            //        Sifra = x.drzava.Sifra
            //    });
            //}

            //ViewData["drzave"] = lista_drzava;

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;

            return View("Prikaz",podaci);
        }
    }
}
