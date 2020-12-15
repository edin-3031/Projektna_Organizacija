using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.IO;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Asn1.Misc;
using Microsoft.AspNetCore.Hosting;
using SelectPdf;
using Aspose.Pdf;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class KorisnikOrgController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";

        public KorisnikOrgController(ApplicationDbContext _db)
        {
            db = _db;
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
                List<adminOrg_kor_orgJed_VM> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Include(a => a.korisnici).Include(a => a.organizacionaJedinica).Select(x => new adminOrg_kor_orgJed_VM
                {

                    korisnik = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    K_O_ID = x.Korisnici_OrganizacionaJedinica_ID,
                    o_j = x.organizacionaJedinica.Naziv

                }).ToList();

                ViewData["kor_org_jed"] = lista_kor_org;


                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Unos()
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
                List<Korisnici> lista_korisnik = db.Korisnici.Select(x => new Korisnici
                {
                    Korisnici_ID = x.Korisnici_ID,
                    Ime = x.Ime,
                    Prezime = x.Prezime
                }).ToList();

                ViewData["korisnik"] = lista_korisnik;

                List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
                {
                    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                    Naziv = x.Naziv,
                }).ToList();

                ViewData["org_jed"] = lista_org_jed;


                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int korisnik, int organizacionaJedinica)
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
                Korisnici_OrganizacionaJedinica temp = new Korisnici_OrganizacionaJedinica
                {
                    Korisnici_FK = korisnik,
                    OrganizacionaJedinica_FK = organizacionaJedinica
                };

                db.Korisnici_OrganizacionaJedinica.Add(temp);
                db.SaveChanges();

                List<adminOrg_kor_orgJed_VM> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Include(a => a.korisnici).Include(a => a.organizacionaJedinica).Select(x => new adminOrg_kor_orgJed_VM
                {

                    korisnik = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    K_O_ID = x.Korisnici_OrganizacionaJedinica_ID,
                    o_j = x.organizacionaJedinica.Naziv

                }).ToList();

                ViewData["kor_org_jed"] = lista_kor_org;

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
                Korisnici_OrganizacionaJedinica temp = db.Korisnici_OrganizacionaJedinica.Where(a => a.Korisnici_OrganizacionaJedinica_ID == id).FirstOrDefault();
                temp.korisnici = db.Korisnici.Where(a => a.Korisnici_ID == temp.Korisnici_FK).FirstOrDefault();
                temp.organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == temp.OrganizacionaJedinica_FK).FirstOrDefault();
                ViewData["kor_oj"] = temp;

                List<Korisnici> k = db.Korisnici.ToList();
                ViewData["korisnici"] = k;

                List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.ToList();
                ViewData["OrganizacionaJedinice"] = org_jed;


                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int k_o_id, int korisnik, int org_jed)
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
                Korisnici_OrganizacionaJedinica t = db.Korisnici_OrganizacionaJedinica.Where(a => a.Korisnici_OrganizacionaJedinica_ID == k_o_id).FirstOrDefault();

                t.Korisnici_FK = korisnik;
                t.OrganizacionaJedinica_FK = org_jed;

                db.SaveChanges();

                List<adminOrg_kor_orgJed_VM> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Include(a => a.korisnici).Include(a => a.organizacionaJedinica).Select(x => new adminOrg_kor_orgJed_VM
                {

                    korisnik = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    K_O_ID = x.Korisnici_OrganizacionaJedinica_ID,
                    o_j = x.organizacionaJedinica.Naziv

                }).ToList();

                ViewData["kor_org_jed"] = lista_kor_org;

                return View("Prikaz");
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
                Korisnici_OrganizacionaJedinica temp = db.Korisnici_OrganizacionaJedinica.Where(v => v.Korisnici_OrganizacionaJedinica_ID == id).SingleOrDefault();

                if (temp != null)
                {
                    db.Korisnici_OrganizacionaJedinica.Remove(temp);
                    db.SaveChanges();
                }

                List<adminOrg_kor_orgJed_VM> lista_kor_org = db.Korisnici_OrganizacionaJedinica.Include(a => a.korisnici).Include(a => a.organizacionaJedinica).Select(x => new adminOrg_kor_orgJed_VM
                {

                    korisnik = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    K_O_ID = x.Korisnici_OrganizacionaJedinica_ID,
                    o_j = x.organizacionaJedinica.Naziv

                }).ToList();

                ViewData["kor_org_jed"] = lista_kor_org;

                return View("Prikaz");
            }
        }
    }
}
