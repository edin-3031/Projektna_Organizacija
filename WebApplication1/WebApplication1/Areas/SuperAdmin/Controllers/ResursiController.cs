using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class ResursiController : Controller
    {
        private readonly ApplicationDbContext db;

        public ResursiController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("SuperAdmin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
            {
                Naziv = x.Naziv,
                Resursi_ID = x.Resursi_ID
            }).ToList();

            ViewData["resursi"] = lista_resursa;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("SuperAdmin")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            Resursi temp = db.Resursi.Where(x => x.Resursi_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Resursi.Remove(temp);
                db.SaveChanges();
            }

            List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
            {
                Naziv = x.Naziv,
                Resursi_ID = x.Resursi_ID
            }).ToList();

            ViewData["resursi"] = lista_resursa;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("SuperAdmin")]
        public IActionResult Unos(int u, int o, int r)
        {
            return View("Unos");
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(string naziv, int u, int o, int r)
        {
            Resursi temp = new Resursi
            {
                Naziv = naziv
            };

            if (temp != null)
            {
                db.Resursi.Add(temp);
                db.SaveChanges();
            }

            List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
            { 
                Naziv=x.Naziv,
                Resursi_ID=x.Resursi_ID
            }).ToList();

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            ViewData["resursi"] = lista_resursa;

            return View("Prikaz");
        }

    }
}
