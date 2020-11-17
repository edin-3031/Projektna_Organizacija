using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Misc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Hosting;
using SelectPdf;
using Aspose.Pdf;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class OrganizacijaController : Controller
    {
        private readonly ApplicationDbContext db;

        public OrganizacijaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("Admin")]
        public IActionResult Excel()
        {

            List<Organizacija> _org = db.Organizacija.ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Organizacija");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Organizacija ID";
                worksheet.Cell(currentRow, 2).Value = "Naziv";
                worksheet.Cell(currentRow, 3).Value = "Šifra";
                worksheet.Cell(currentRow, 4).Value = "Adresa";
                worksheet.Cell(currentRow, 5).Value = "Država";
                worksheet.Cell(currentRow, 6).Value = "PTT";

                foreach (var x in _org)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Organizacija_ID;
                    worksheet.Cell(currentRow, 2).Value = x.Naziv;
                    worksheet.Cell(currentRow, 3).Value = x.Sifra;
                    worksheet.Cell(currentRow, 4).Value = x.Adresa;
                    worksheet.Cell(currentRow, 5).Value = db.Drzava.Where(a => a.Drazava_ID == x.Drzava_FK).Select(o => o.Naziv).FirstOrDefault();
                    worksheet.Cell(currentRow, 6).Value = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(o => o.Naziv).FirstOrDefault();
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "OrganizacijaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        [Area("Admin")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            Organizacija temp = db.Organizacija.Where(x => x.Organizacija_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Organizacija.Remove(temp);
                db.SaveChanges();
            }

            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa = x.Adresa,
                Drzava_FK = x.Drzava_FK,
                Naziv = x.Naziv,
                Organizacija_ID = x.Organizacija_ID,
                PTT_FK = x.PTT_FK,
                Sifra = x.Sifra,
                drzava = db.Drzava.Where(c => c.Drazava_ID == x.Drzava_FK).FirstOrDefault(),
                ptt = db.PTT.Where(v => v.PTT_ID == x.PTT_FK).FirstOrDefault()
            }).ToList();

            ViewData["organizacija"] = lista_organizacija;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult UnosSnimi(int ptt, int drzava, int sifra, string naziv, string adresa, int u, int o, int r, IFormFile file)
        {
            Organizacija temp = new Organizacija
            {
                Adresa = adresa,
                Drzava_FK = drzava,
                Naziv = naziv,
                PTT_FK = ptt,
                Sifra = sifra
            };

            if (file.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    file.CopyTo(stream);

                    temp.Slika = stream.ToArray();
                }
            }

            db.Organizacija.Add(temp);

            db.SaveChanges();

            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa = x.Adresa,
                Drzava_FK = x.Drzava_FK,
                Naziv = x.Naziv,
                Organizacija_ID = x.Organizacija_ID,
                PTT_FK = x.PTT_FK,
                Sifra = x.Sifra,
                drzava = db.Drzava.Where(c => c.Drazava_ID == x.Drzava_FK).FirstOrDefault(),
                ptt = db.PTT.Where(v => v.PTT_ID == x.PTT_FK).FirstOrDefault()
            }).ToList();

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            ViewData["organizacija"] = lista_organizacija;
            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Unos(int u, int o, int r) {

            List<PTT> lista_ptt = db.PTT.Select(y => new PTT
            {
                Naziv = y.Naziv,
                PTT_ID = y.PTT_ID,
                Sifra = y.Sifra
            }).ToList();

            List<Drzava> lista_drzava = db.Drzava.Select(z => new Drzava
            {
                Drazava_ID = z.Drazava_ID,
                Sifra = z.Sifra,
                Naziv = z.Naziv
            }).ToList();

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
        [Area("Admin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
            {
                Adresa=x.Adresa,
                Drzava_FK=x.Drzava_FK,
                Naziv=x.Naziv,
                Organizacija_ID=x.Organizacija_ID,
                PTT_FK=x.PTT_FK,
                Sifra=x.Sifra,
                drzava=db.Drzava.Where(c=>c.Drazava_ID==x.Drzava_FK).FirstOrDefault(),
                ptt=db.PTT.Where(v=>v.PTT_ID==x.PTT_FK).FirstOrDefault()
            }).ToList();

            ViewData["organizacija"] = lista_organizacija;

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
