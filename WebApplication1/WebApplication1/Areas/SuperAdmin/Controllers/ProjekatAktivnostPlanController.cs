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
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";


        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
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
            else
            {
                List<ProjekatAktivnostPlan> proj_aktiv_plan = db.ProjekatAktivnostPlan.ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Projekat_aktivnos_Plan");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Projekat Aktivnost Plan ID";
                    worksheet.Cell(currentRow, 2).Value = "Naziv";
                    worksheet.Cell(currentRow, 3).Value = "Šifra";
                    worksheet.Cell(currentRow, 4).Value = "Projekat plan";
                    worksheet.Cell(currentRow, 5).Value = "Datum od";
                    worksheet.Cell(currentRow, 6).Value = "Datum do";
                    worksheet.Cell(currentRow, 7).Value = "Količina";
                    worksheet.Cell(currentRow, 8).Value = "Jedinica mjere";

                    foreach (var x in proj_aktiv_plan)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.ProjekatAktivnostPlan_ID;
                        worksheet.Cell(currentRow, 2).Value = x.Naziv;
                        worksheet.Cell(currentRow, 3).Value = x.Sifra;
                        worksheet.Cell(currentRow, 4).Value = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault();
                        worksheet.Cell(currentRow, 5).Value = x.DatumOd;
                        worksheet.Cell(currentRow, 6).Value = x.DatumDo;
                        worksheet.Cell(currentRow, 7).Value = x.Kolicina;
                        worksheet.Cell(currentRow, 8).Value = x.JedinicaMjere;
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Projekat-Aktivnost-PlanInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
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
            else
            {
                List<ProjekatAktivnostPlanVM> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Include(a => a.projekatPlan).Select(x => new ProjekatAktivnostPlanVM
                {
                    Sifra = x.Sifra,
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    JedinicaMjere = x.JedinicaMjere,
                    Kolicina = x.Kolicina,
                    Naziv = x.Naziv,
                    ProjekatPlan_id = x.ProjekatPlan_FK,
                    ProjekatPlan_naziv = x.projekatPlan.Naziv,
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
                }).ToList();

                ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;



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
            else
            {
                List<ProjekatPlanVM> lista_proj_plan = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlanVM
                {
                    Naziv = x.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    OrganizacionaJedinica_id = x.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv
                }).ToList();

                ViewData["lista_proj_plan"] = lista_proj_plan;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ProjekatAktivnostPlan temp = new ProjekatAktivnostPlan
                {
                    DatumDo = Do,
                    DatumOd = Od,
                    JedinicaMjere = jedinicaMjere,
                    Kolicina = kolicina,
                    Naziv = naziv,
                    ProjekatPlan_FK = projekatPlan,
                    Sifra = sifra
                };

                db.ProjekatAktivnostPlan.Add(temp);
                db.SaveChanges();

                List<ProjekatAktivnostPlanVM> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Include(a => a.projekatPlan).Select(x => new ProjekatAktivnostPlanVM
                {
                    Sifra = x.Sifra,
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    JedinicaMjere = x.JedinicaMjere,
                    Kolicina = x.Kolicina,
                    Naziv = x.Naziv,
                    ProjekatPlan_id = x.ProjekatPlan_FK,
                    ProjekatPlan_naziv = x.projekatPlan.Naziv,
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
                }).ToList();

                ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

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
            else
            {
                ProjekatAktivnostPlan temp = db.ProjekatAktivnostPlan.Where(x => x.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.ProjekatAktivnostPlan.Remove(temp);
                    db.SaveChanges();
                }

                List<ProjekatAktivnostPlanVM> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Include(a => a.projekatPlan).Select(x => new ProjekatAktivnostPlanVM
                {
                    Sifra = x.Sifra,
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    JedinicaMjere = x.JedinicaMjere,
                    Kolicina = x.Kolicina,
                    Naziv = x.Naziv,
                    ProjekatPlan_id = x.ProjekatPlan_FK,
                    ProjekatPlan_naziv = x.projekatPlan.Naziv,
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
                }).ToList();

                ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

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
            else
            {
                ProjekatAktivnostPlan p_a = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();
                p_a.projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == p_a.ProjekatPlan_FK).FirstOrDefault();

                ViewData["proj_aktiv"] = p_a;


                List<ProjekatPlanVM> p_p = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlanVM
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_id = x.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    Status_id = x.status.StatusID,
                    Status_naziv = x.status.Naziv
                }).ToList();

                ViewData["p_p"] = p_p;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, DateTime OD, DateTime DO, string jedinicaMjere, float kolicina, string naziv, int proj_plan_id, int sifra)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                ProjekatAktivnostPlan t = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

                t.DatumDo = DO;
                t.DatumOd = OD;
                t.JedinicaMjere = jedinicaMjere;
                t.Kolicina = kolicina;
                t.Naziv = naziv;
                t.ProjekatPlan_FK = proj_plan_id;
                t.Sifra = sifra;

                db.SaveChanges();

                List<ProjekatAktivnostPlanVM> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Include(a => a.projekatPlan).Select(x => new ProjekatAktivnostPlanVM
                {
                    Sifra = x.Sifra,
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    JedinicaMjere = x.JedinicaMjere,
                    Kolicina = x.Kolicina,
                    Naziv = x.Naziv,
                    ProjekatPlan_id = x.ProjekatPlan_FK,
                    ProjekatPlan_naziv = x.projekatPlan.Naziv,
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
                }).ToList();

                ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

                return View("Prikaz");
            }
        }
    }
}