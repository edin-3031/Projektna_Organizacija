using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
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

namespace WebApplication1.Areas.Admin.Controllers
{
    public class KorisnikOrgController : Controller
    {
        private readonly ApplicationDbContext db;
        public KorisnikOrgController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("Admin")]
        public IActionResult Excel()
        {

            List<Korisnici_OrganizacionaJedinica> kor_org = db.Korisnici_OrganizacionaJedinica.ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Korisnik_organizacionaJedinica");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Korisnici-Organizaciona jedinica ID";
                worksheet.Cell(currentRow, 2).Value = "Korisnik";
                worksheet.Cell(currentRow, 3).Value = "Organizaciona jedinica";

                foreach (var x in kor_org)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Korisnici_OrganizacionaJedinica_ID;
                    worksheet.Cell(currentRow, 2).Value = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime.ToString() + " " + o.Prezime.ToString()).FirstOrDefault();
                    worksheet.Cell(currentRow, 3).Value = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).Select(o => o.Naziv.ToString()).FirstOrDefault();
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Korisnici-OrganizacionaJedinicaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        [Area("Admin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<Korisnici_OrganizacionaJedinica> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Select(x => new Korisnici_OrganizacionaJedinica
            {
                korisnici=db.Korisnici.Where(c=>c.Korisnici_ID==x.Korisnici_FK).SingleOrDefault(),
                Korisnici_FK=x.Korisnici_FK,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(v=>v.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).SingleOrDefault(),
                OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                Korisnici_OrganizacionaJedinica_ID=x.Korisnici_OrganizacionaJedinica_ID
            }).ToList();

            ViewData["kor_org_jed"]=lista_kor_org;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("Admin")]
        public IActionResult Unos(int u, int o, int r)
        {
            List<Korisnici> lista_korisnik = db.Korisnici.Select(x => new Korisnici
            {
                Korisnici_ID=x.Korisnici_ID,
                Ime=x.Ime,
                Prezime=x.Prezime
            }).ToList();

            ViewData["korisnik"] = lista_korisnik;

            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            {
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID,
                Naziv=x.Naziv,
            }).ToList();

            ViewData["org_jed"] = lista_org_jed;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int korisnik, int organizacionaJedinica, int u, int o, int r)
        {
            Korisnici_OrganizacionaJedinica temp = new Korisnici_OrganizacionaJedinica
            {
                Korisnici_FK = korisnik,
                OrganizacionaJedinica_FK = organizacionaJedinica
            };

            db.Korisnici_OrganizacionaJedinica.Add(temp);
            db.SaveChanges();

            List<Korisnici_OrganizacionaJedinica> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Select(x => new Korisnici_OrganizacionaJedinica
            {
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).SingleOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                organizacionaJedinica = db.OrganizacionaJedinica.Where(v => v.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).SingleOrDefault(),
                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID
            }).ToList();

            ViewData["kor_org_jed"] = lista_kor_org;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("Admin")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            Korisnici_OrganizacionaJedinica temp = db.Korisnici_OrganizacionaJedinica.Where(v => v.Korisnici_OrganizacionaJedinica_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Korisnici_OrganizacionaJedinica.Remove(temp);
                db.SaveChanges();
            }

            List<Korisnici_OrganizacionaJedinica> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Select(x => new Korisnici_OrganizacionaJedinica
            {
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).SingleOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                organizacionaJedinica = db.OrganizacionaJedinica.Where(v => v.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).SingleOrDefault(),
                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID
            }).ToList();

            ViewData["kor_org_jed"] = lista_kor_org;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
    }
}
