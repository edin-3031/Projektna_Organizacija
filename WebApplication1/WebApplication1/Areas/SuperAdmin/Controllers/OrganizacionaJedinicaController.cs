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
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class OrganizacionaJedinicaController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";


        public OrganizacionaJedinicaController(ApplicationDbContext _db)
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
                List<OrganizacionaJedinica> _org_jed = db.OrganizacionaJedinica.ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Organizaciona_jedinica");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Organizaciona jedinica ID";
                    worksheet.Cell(currentRow, 2).Value = "Naziv";
                    worksheet.Cell(currentRow, 3).Value = "Adresa";
                    worksheet.Cell(currentRow, 4).Value = "Organizacija";
                    worksheet.Cell(currentRow, 5).Value = "Država";
                    worksheet.Cell(currentRow, 6).Value = "PTT";

                    foreach (var x in _org_jed)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.OrganizacionaJedinica_ID;
                        worksheet.Cell(currentRow, 2).Value = x.Naziv;
                        worksheet.Cell(currentRow, 3).Value = x.Adresa;
                        worksheet.Cell(currentRow, 4).Value = db.Organizacija.Where(a => a.Organizacija_ID == x.Organizacija_FK).Select(o => o.Naziv).FirstOrDefault();
                        worksheet.Cell(currentRow, 5).Value = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).Select(o => o.Naziv).FirstOrDefault();
                        worksheet.Cell(currentRow, 6).Value = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(o => o.Naziv).FirstOrDefault();
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "OrganizacionaJedinicaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
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
                List<OrganizacionaJedinicaVM> lista_org_jed = db.OrganizacionaJedinica.Include(a => a.drzava).Include(a => a.ptt).Include(a => a.organizacija).Select(x => new OrganizacionaJedinicaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Naziv = x.Naziv,
                    Organizacija_id = x.organizacija.Organizacija_ID,
                    Organizacija_naziv = x.organizacija.Naziv,
                    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                    PTT_id = x.ptt.PTT_ID,
                    PTT_naziv = x.ptt.Naziv
                }).ToList();

                ViewData["org_jed"] = lista_org_jed;



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
                List<Organizacija> lista_organizacija = db.Organizacija.Select(x => new Organizacija
                {
                    Adresa = x.Adresa,
                    Naziv = x.Naziv,
                    Organizacija_ID = x.Organizacija_ID,
                    Sifra = x.Sifra
                }).ToList();


                List<PTT> lista_ptt = db.PTT.Select(x => new PTT
                {
                    Naziv = x.Naziv,
                    Sifra = x.Sifra,
                    PTT_ID = x.PTT_ID
                }).ToList();


                List<Drzava> lista_drzava = db.Drzava.Select(x => new Drzava
                {
                    Drzava_ID = x.Drzava_ID,
                    Sifra = x.Sifra,
                    Naziv = x.Naziv
                }).ToList();

                ViewData["organizacije"] = lista_organizacija;
                ViewData["ptt"] = lista_ptt;
                ViewData["drzava"] = lista_drzava;



                return View("Unos");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int organizacija, int ptt, int drzava, string naziv, string adresa)
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
                OrganizacionaJedinica temp = new OrganizacionaJedinica
                {
                    Adresa = adresa,
                    Drzava_FK = drzava,
                    Naziv = naziv,
                    Organizacija_FK = organizacija,
                    PTT_FK = ptt
                };

                db.OrganizacionaJedinica.Add(temp);
                db.SaveChanges();

                List<OrganizacionaJedinicaVM> lista_org_jed = db.OrganizacionaJedinica.Include(a => a.drzava).Include(a => a.ptt).Include(a => a.organizacija).Select(x => new OrganizacionaJedinicaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Naziv = x.Naziv,
                    Organizacija_id = x.organizacija.Organizacija_ID,
                    Organizacija_naziv = x.organizacija.Naziv,
                    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                    PTT_id = x.ptt.PTT_ID,
                    PTT_naziv = x.ptt.Naziv
                }).ToList();

                ViewData["org_jed"] = lista_org_jed;

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
                OrganizacionaJedinica temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.OrganizacionaJedinica.Remove(temp);
                    db.SaveChanges();
                }

                List<OrganizacionaJedinicaVM> lista_org_jed = db.OrganizacionaJedinica.Include(a => a.drzava).Include(a => a.ptt).Include(a => a.organizacija).Select(x => new OrganizacionaJedinicaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Naziv = x.Naziv,
                    Organizacija_id = x.organizacija.Organizacija_ID,
                    Organizacija_naziv = x.organizacija.Naziv,
                    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                    PTT_id = x.ptt.PTT_ID,
                    PTT_naziv = x.ptt.Naziv
                }).ToList();

                ViewData["org_jed"] = lista_org_jed;

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
                OrganizacionaJedinica temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id).FirstOrDefault();

                temp.drzava = db.Drzava.Where(a => a.Drzava_ID == temp.Drzava_FK).FirstOrDefault();
                temp.organizacija = db.Organizacija.Where(a => a.Organizacija_ID == temp.Organizacija_FK).FirstOrDefault();
                temp.ptt = db.PTT.Where(a => a.PTT_ID == temp.PTT_FK).FirstOrDefault();

                ViewData["org_jed"] = temp;

                List<PTT> ptt_lista = db.PTT.ToList();
                ViewData["ptt"] = ptt_lista;

                List<Drzava> drzava_lista = db.Drzava.ToList();
                ViewData["drzava"] = drzava_lista;

                List<Organizacija> organizacija_lista = db.Organizacija.ToList();
                ViewData["organizacija"] = organizacija_lista;

                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id_org_jed, string naziv, int organizacija, string adresa, int drzava, int ptt)
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
                OrganizacionaJedinica t = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == id_org_jed).FirstOrDefault();

                t.Naziv = naziv;
                t.Adresa = adresa;
                t.Drzava_FK = drzava;
                t.Organizacija_FK = organizacija;
                t.PTT_FK = ptt;

                db.SaveChanges();

                List<OrganizacionaJedinicaVM> lista_org_jed = db.OrganizacionaJedinica.Include(a => a.drzava).Include(a => a.ptt).Include(a => a.organizacija).Select(x => new OrganizacionaJedinicaVM
                {
                    Adresa = x.Adresa,
                    Drzava_id = x.drzava.Drzava_ID,
                    Drzava_naziv = x.drzava.Naziv,
                    Naziv = x.Naziv,
                    Organizacija_id = x.organizacija.Organizacija_ID,
                    Organizacija_naziv = x.organizacija.Naziv,
                    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                    PTT_id = x.ptt.PTT_ID,
                    PTT_naziv = x.ptt.Naziv
                }).ToList();

                ViewData["org_jed"] = lista_org_jed;

                return View("Prikaz");
            }
        }
    }
}