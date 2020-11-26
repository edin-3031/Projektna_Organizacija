using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class DrzavaController : Controller
    {
        private readonly ApplicationDbContext db;

        public DrzavaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public uor podaci;

        [Area("SuperAdmin")]
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

        [Area("SuperAdmin")]
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

        [Area("SuperAdmin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;

            return View(podaci);
        }



        [Area("SuperAdmin")]
        public IActionResult Unos(int u, int o, int r)
        {
            podaci = new uor();

            podaci.userId = u;
            podaci.organisationId = o;
            podaci.roleId = r;

            ViewData["id"] = podaci;

            return View("Unos");
        }
        [Area("SuperAdmin")]
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

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;


            return View("Prikaz",podaci);
        }
        [Area("SuperAdmin")]
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

            List<Drzava> lista_drzava = db.Drzava.ToList();

            ViewData["drzave"] = lista_drzava;

            return View("Prikaz",podaci);
        }
    }
}
