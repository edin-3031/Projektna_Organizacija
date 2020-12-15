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
    public class ProjekatPlanController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";

        public ProjekatPlanController(ApplicationDbContext _db)
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
                List<ProjekatPlan> proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault(),
                    Status_FK = x.Status_FK,
                    organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra
                }).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Projekat_Plan");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Projekat Plan ID";
                    worksheet.Cell(currentRow, 2).Value = "Naziv";
                    worksheet.Cell(currentRow, 3).Value = "Šifra";
                    worksheet.Cell(currentRow, 4).Value = "Datum od";
                    worksheet.Cell(currentRow, 5).Value = "Datum do";
                    worksheet.Cell(currentRow, 6).Value = "Organizaciona Jedinica";
                    worksheet.Cell(currentRow, 7).Value = "Status";

                    foreach (var x in proj_plan)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.ProjekatPlan_ID;
                        worksheet.Cell(currentRow, 2).Value = x.Naziv;
                        worksheet.Cell(currentRow, 3).Value = x.Sifra;
                        worksheet.Cell(currentRow, 4).Value = x.DatumOd;
                        worksheet.Cell(currentRow, 5).Value = x.DatumDo;
                        worksheet.Cell(currentRow, 6).Value = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).Select(o => o.Naziv).FirstOrDefault();
                        worksheet.Cell(currentRow, 7).Value = x.status.Naziv;
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Projekat-PlanInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
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
                List<ProjekatPlanVM> lista_proj_plan = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlanVM
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_id = x.OrganizacionaJedinica_FK,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    Status_id = x.Status_FK,
                    Status_naziv = x.status.Naziv
                }).ToList();

                ViewData["proj_plan"] = lista_proj_plan;

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
                List<OrganizacionaJedinicaVM> lista_org_jed = db.OrganizacionaJedinica.Include(a => a.drzava).Include(a => a.organizacija).Include(a => a.ptt).Select(x => new OrganizacionaJedinicaVM
                {
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_ID = x.OrganizacionaJedinica_ID,
                    PTT_id = x.PTT_FK,
                    PTT_naziv = x.ptt.Naziv,
                    Drzava_id = x.Drzava_FK,
                    Drzava_naziv = x.drzava.Naziv,
                    Adresa = x.Adresa,
                    Organizacija_id = x.Organizacija_FK,
                    Organizacija_naziv = x.organizacija.Naziv
                }).ToList();

                ViewData["lista_org_jed"] = lista_org_jed;

                List<Status> stat_lista = db.Status.ToList();
                ViewData["statusi"] = stat_lista;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int organizacionaJedinica, int sifra, string naziv, DateTime Od, DateTime Do, int status_id)
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
                ProjekatPlan temp = new ProjekatPlan
                {
                    DatumDo = Do,
                    DatumOd = Od,
                    Naziv = naziv,
                    OrganizacionaJedinica_FK = organizacionaJedinica,
                    Sifra = sifra,
                    Status_FK = status_id
                };

                db.ProjekatPlan.Add(temp);
                db.SaveChanges();

                List<ProjekatPlanVM> lista_proj_plan = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlanVM
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_id = x.OrganizacionaJedinica_FK,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    Status_id = x.Status_FK,
                    Status_naziv = x.status.Naziv
                }).ToList();

                ViewData["proj_plan"] = lista_proj_plan;

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
                ProjekatPlan temp = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.ProjekatPlan.Remove(temp);
                    db.SaveChanges();
                }

                List<ProjekatPlanVM> lista_proj_plan = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlanVM
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_id = x.OrganizacionaJedinica_FK,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    Status_id = x.Status_FK,
                    Status_naziv = x.status.Naziv
                }).ToList();

                ViewData["proj_plan"] = lista_proj_plan;

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
                List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.ToList();

                ViewData["org_jed"] = org_jed_lista;

                ProjekatPlan p = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();
                p.organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == p.OrganizacionaJedinica_FK).FirstOrDefault();
                p.status = db.Status.Where(a => a.StatusID == p.Status_FK).FirstOrDefault();
                ViewData["projekat"] = p;

                List<Status> stat_lista = db.Status.ToList();
                ViewData["statusi"] = stat_lista;

                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, DateTime DO, DateTime OD, string naziv, int org_jed, int sifra, int status_id)
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
                ProjekatPlan t = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();

                t.DatumDo = DO;
                t.DatumOd = OD;
                t.Naziv = naziv;
                t.OrganizacionaJedinica_FK = org_jed;
                t.Sifra = sifra;
                t.Status_FK = status_id;

                db.SaveChanges();

                List<ProjekatPlanVM> lista_proj_plan = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlanVM
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_id = x.OrganizacionaJedinica_FK,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    Status_id = x.Status_FK,
                    Status_naziv = x.status.Naziv
                }).ToList();

                ViewData["proj_plan"] = lista_proj_plan;

                return View("Prikaz");
            }
        }
    }
}