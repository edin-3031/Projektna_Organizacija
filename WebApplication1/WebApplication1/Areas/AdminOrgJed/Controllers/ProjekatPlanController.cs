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

namespace WebApplication1.Areas.AdminOrgJed.Controllers
{
    public class ProjekatPlanController : Controller
    {
        private readonly ApplicationDbContext db;
        string poruka = "Morate se ponovo prijaviti";

        public ProjekatPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("AdminOrgJed")]
        public IActionResult Excel()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Select(x=>new ProjekatPlan {
                DatumDo = x.DatumDo,
                DatumOd = x.DatumOd,
                Naziv = x.Naziv,
                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                ProjekatPlan_ID = x.ProjekatPlan_ID,
                Sifra = x.Sifra,
                organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                Status_FK = x.Status_FK,
                status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
            }).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Projekat_Plan");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Šifra";
                    worksheet.Cell(currentRow, 2).Value = "Naziv";
                    worksheet.Cell(currentRow, 3).Value = "Datum od";
                    worksheet.Cell(currentRow, 4).Value = "Datum do";
                    worksheet.Cell(currentRow, 5).Value = "Status";

                    foreach (var x in pp_final)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.Sifra;
                        worksheet.Cell(currentRow, 2).Value = x.Naziv;
                        worksheet.Cell(currentRow, 3).Value = x.DatumOd.Date.Day + "." + x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".";
                        worksheet.Cell(currentRow, 4).Value = x.DatumDo.Date.Day + "." + x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".";
                        worksheet.Cell(currentRow, 5).Value = x.status.Naziv; ;
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

        [Area("AdminOrgJed")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                    Status_FK = x.Status_FK,
                    status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                }).ToList();

                ViewData["proj_plan"] = pp_final;

                return View();
            }
        }
        [Area("AdminOrgJed")]
        public IActionResult Unos()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<Status> stat_lista = db.Status.ToList();
                ViewData["statusi"] = stat_lista;

                return View();
            }
        }
        [Area("AdminOrgJed")]
        public IActionResult UnosSnimi(int sifra, string naziv, DateTime Od, DateTime Do, int status_id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan temp = new ProjekatPlan
                {
                    DatumDo = Do,
                    DatumOd = Od,
                    Naziv = naziv,
                    OrganizacionaJedinica_FK = (int)HttpContext.Session.GetInt32("orgJed ID"),
                    Sifra = sifra,
                    Status_FK = status_id
                };

                db.Add(temp);
                db.SaveChanges();

                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                    Status_FK = x.Status_FK,
                    status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                }).ToList();

                ViewData["proj_plan"] = pp_final;

                return View("Prikaz");
            }
        }
        [Area("AdminOrgJed")]
        public IActionResult Ukloni(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan temp = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.ProjekatPlan.Remove(temp);
                    db.SaveChanges();
                }

                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                    Status_FK = x.Status_FK,
                    status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                }).ToList();

                ViewData["proj_plan"] = pp_final;

                return View("Prikaz");
            }
        }

        [Area("AdminOrgJed")]
        public IActionResult Uredi(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan p = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();
                p.organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == p.OrganizacionaJedinica_FK).FirstOrDefault();
                ViewData["projekat"] = p;

                List<Status> stat_lista = db.Status.ToList();
                ViewData["statusi"] = stat_lista;

                return View();
            }
        }

        [Area("AdminOrgJed")]
        public IActionResult UrediSnimi(int id, DateTime DO, DateTime OD, string naziv, int sifra, int status_id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan t = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();

                t.DatumDo = DO;
                t.DatumOd = OD;
                t.Naziv = naziv;
                t.OrganizacionaJedinica_FK = (int)HttpContext.Session.GetInt32("orgJed ID");
                t.Sifra = sifra;
                t.Status_FK = status_id;

                db.SaveChanges();

                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                    Status_FK = x.Status_FK,
                    status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                }).ToList();

                ViewData["proj_plan"] = pp_final;

                return View("Prikaz");
            }
        }
    }
}