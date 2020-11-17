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
    public class KorisnikController : Controller
    {
        private readonly ApplicationDbContext db;

        public KorisnikController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("Admin")]
        public IActionResult Excel()
        {

            List<Korisnici> korisnik = db.Korisnici.ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Korisnici");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Korisnik ID";
                worksheet.Cell(currentRow, 2).Value = "Ime i prezime";
                worksheet.Cell(currentRow, 3).Value = "Korisničko ime";
                worksheet.Cell(currentRow, 4).Value = "Lozinka";
                worksheet.Cell(currentRow, 5).Value = "Šifra";
                worksheet.Cell(currentRow, 6).Value = "Mail";
                worksheet.Cell(currentRow, 7).Value = "Telefon";
                worksheet.Cell(currentRow, 8).Value = "Uloga";

                foreach (var x in korisnik)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Korisnici_ID;
                    worksheet.Cell(currentRow, 2).Value = x.Ime.ToString() + " " + x.Prezime.ToString();
                    worksheet.Cell(currentRow, 3).Value = x.Korisnicko_Ime;
                    worksheet.Cell(currentRow, 4).Value = x.Lozinka;
                    worksheet.Cell(currentRow, 5).Value = x.Sifra;
                    worksheet.Cell(currentRow, 6).Value = x.Mail;
                    worksheet.Cell(currentRow, 7).Value = x.Telefon;
                    worksheet.Cell(currentRow, 8).Value = db.Uloge.Where(a=>a.Uloge_ID== x.Uloge_FK).Select(o=>o.Naziv).FirstOrDefault();
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "KorisniciInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
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