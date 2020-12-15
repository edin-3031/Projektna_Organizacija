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
using Org.BouncyCastle.Asn1.Misc;
using Microsoft.AspNetCore.Hosting;
using SelectPdf;
using Aspose.Pdf;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class OrganizacijaController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";


        public OrganizacijaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        [HttpPost]
        public IActionResult UrediSnimi(int org_id, int ptt, int drzava, int sifra, string naziv, string adresa, IFormFile slika, IFormFile logo)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }

            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Organizacija t = db.Organizacija.Where(a => a.Organizacija_ID == org_id).FirstOrDefault();

                t.PTT_FK = ptt;
                t.Drzava_FK = drzava;
                t.Sifra = sifra;
                t.Naziv = naziv;
                t.Adresa = adresa;

                if (slika != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        slika.CopyTo(stream);

                        t.Slika = stream.ToArray();
                    }
                }

                if (logo != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        logo.CopyTo(stream);

                        t.Logo = stream.ToArray();
                    }
                }

                db.SaveChanges();

                List<OrganizacijaVM> lista_organizacija = db.Organizacija.Include(c => c.drzava).Include(c => c.ptt).Select(x => new OrganizacijaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Logo = x.Logo,
                    Naziv = x.Naziv,
                    Organizacija_ID = x.Organizacija_ID,
                    Sifra = x.Sifra,
                    Slika = x.Slika,
                    PTT_naziv = x.ptt.Naziv,
                    PTT_id = x.ptt.PTT_ID
                }).ToList();

                ViewData["organizacija"] = lista_organizacija;

                return View("Prikaz");
            }
        }

        [Area("SuperAdmin")]
        public IActionResult Uredi(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Organizacija org_temp = db.Organizacija.Where(a => a.Organizacija_ID == id).FirstOrDefault();

                org_temp.ptt = db.PTT.Where(a => a.PTT_ID == org_temp.PTT_FK).FirstOrDefault();
                org_temp.drzava = db.Drzava.Where(a => a.Drzava_ID == org_temp.Drzava_FK).FirstOrDefault();

                ViewData["organizacija_uredi"] = org_temp;


                List<PTT> lista_ptt = db.PTT.Select(y => new PTT
                {
                    Naziv = y.Naziv,
                    PTT_ID = y.PTT_ID,
                    Sifra = y.Sifra
                }).ToList();

                List<Drzava> lista_drzava = db.Drzava.Select(z => new Drzava
                {
                    Drzava_ID = z.Drzava_ID,
                    Sifra = z.Sifra,
                    Naziv = z.Naziv
                }).ToList();

                ViewData["ptt"] = lista_ptt;
                ViewData["drzava"] = lista_drzava;

                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult Excel()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
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
                        worksheet.Cell(currentRow, 5).Value = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).Select(o => o.Naziv).FirstOrDefault();
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
        }

        [Area("SuperAdmin")]
        public IActionResult Ukloni(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Organizacija temp = db.Organizacija.Where(x => x.Organizacija_ID == id).SingleOrDefault();

                if (temp != null)
                {
                    db.Organizacija.Remove(temp);
                    db.SaveChanges();
                }

                List<OrganizacijaVM> lista_organizacija = db.Organizacija.Include(c => c.drzava).Include(c => c.ptt).Select(x => new OrganizacijaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Logo = x.Logo,
                    Naziv = x.Naziv,
                    Organizacija_ID = x.Organizacija_ID,
                    Sifra = x.Sifra,
                    Slika = x.Slika,
                    PTT_naziv = x.ptt.Naziv,
                    PTT_id = x.ptt.PTT_ID
                }).ToList();

                ViewData["organizacija"] = lista_organizacija;

                return View("Prikaz");
            }
        }

        [Area("SuperAdmin")]
        [HttpPost]
        public IActionResult UnosSnimi(int ptt, int drzava, int sifra, string naziv, string adresa, IFormFile slika=null, IFormFile logo=null)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                Organizacija temp = new Organizacija
                {
                    Adresa = adresa,
                    Drzava_FK = drzava,
                    Naziv = naziv,
                    PTT_FK = ptt,
                    Sifra = sifra
                };

                if (slika != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        slika.CopyTo(stream);

                        temp.Slika = stream.ToArray();
                    }
                }

                if (logo != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        logo.CopyTo(stream);

                        temp.Logo = stream.ToArray();
                    }
                }

                db.Organizacija.Add(temp);

                db.SaveChanges();

                List<OrganizacijaVM> lista_organizacija = db.Organizacija.Include(c => c.drzava).Include(c => c.ptt).Select(x => new OrganizacijaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Logo = x.Logo,
                    Naziv = x.Naziv,
                    Organizacija_ID = x.Organizacija_ID,
                    Sifra = x.Sifra,
                    Slika = x.Slika,
                    PTT_naziv = x.ptt.Naziv,
                    PTT_id = x.ptt.PTT_ID
                }).ToList();

                ViewData["organizacija"] = lista_organizacija;



                return View("Prikaz");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Unos() {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<PTT> lista_ptt = db.PTT.Select(y => new PTT
                {
                    Naziv = y.Naziv,
                    PTT_ID = y.PTT_ID,
                    Sifra = y.Sifra
                }).ToList();

                List<Drzava> lista_drzava = db.Drzava.Select(z => new Drzava
                {
                    Drzava_ID = z.Drzava_ID,
                    Sifra = z.Sifra,
                    Naziv = z.Naziv
                }).ToList();

                ViewData["ptt"] = lista_ptt;
                ViewData["drzava"] = lista_drzava;



                return View("Unos");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<OrganizacijaVM> lista_organizacija = db.Organizacija.Include(c => c.drzava).Include(c => c.ptt).Select(x => new OrganizacijaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Logo = x.Logo,
                    Naziv = x.Naziv,
                    Organizacija_ID = x.Organizacija_ID,
                    Sifra = x.Sifra,
                    Slika = x.Slika,
                    PTT_naziv = x.ptt.Naziv,
                    PTT_id = x.ptt.PTT_ID
                }).ToList();

                ViewData["organizacija"] = lista_organizacija;

                return View("Prikaz");
            }
        }
    }
}