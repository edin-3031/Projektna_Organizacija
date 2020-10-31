using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ResursiController : Controller
    {
        private readonly ApplicationDbContext db;

        public ResursiController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Prikaz()
        {
            List<Resursi> lista_resursa = db.Resursi.Select(x => new Resursi
            {
                Naziv = x.Naziv,
                Resursi_ID = x.Resursi_ID
            }).ToList();

            ViewData["resursi"] = lista_resursa;

            return View("Prikaz");
        }

        public IActionResult Ukloni(int id)
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

            return View("Prikaz");
        }

        public IActionResult Unos()
        {
            return View("Unos");
        }

        public IActionResult UnosSnimi(string naziv)
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

            ViewData["resursi"] = lista_resursa;

            return View("Prikaz");
        }

    }
}
