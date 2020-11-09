﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class PTTController : Controller
    {
        private readonly ApplicationDbContext db;
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public PTTController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("Admin")]
        public IActionResult Prikaz()
        {
            List<PTT> lista_ptt = db.PTT.Select(x => new PTT
            {
                Naziv=x.Naziv,
                PTT_ID=x.PTT_ID,
                Sifra=x.Sifra
            }).ToList();

            ViewData["ptt"] = lista_ptt;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Unos()
        {
            return View("Unos");
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int sifra, string naziv)
        {
            PTT temp = new PTT
            {
                Naziv = naziv,
                Sifra = sifra
            };

            db.PTT.Add(temp);
            db.SaveChanges();

            List<PTT> lista_ptt = db.PTT.Select(x => new PTT
            {
                Naziv = x.Naziv,
                PTT_ID = x.PTT_ID,
                Sifra = x.Sifra
            }).ToList();

            ViewData["ptt"] = lista_ptt;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id)
        {
            PTT temp = db.PTT.Where(x => x.PTT_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.PTT.Remove(temp);
                db.SaveChanges();
            }

            List<PTT> lista_ptt = db.PTT.Select(x => new PTT
            {
                Naziv = x.Naziv,
                PTT_ID = x.PTT_ID,
                Sifra = x.Sifra
            }).ToList();

            ViewData["ptt"] = lista_ptt;
            return View("Prikaz");
        }


    }
}