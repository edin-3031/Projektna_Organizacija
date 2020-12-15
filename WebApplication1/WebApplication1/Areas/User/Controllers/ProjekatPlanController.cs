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

namespace WebApplication1.Areas.User.Controllers
{
    public class ProjekatPlanController : Controller
    {
        private readonly ApplicationDbContext db;
        string poruka = "Morate se ponovo prijaviti";
        string poruka2 = "Nemate pravo pristupa";

        public ProjekatPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("User")]
        public IActionResult Excel()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }

            if (HttpContext.Session.GetString("role") != "User")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {

                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Include(a => a.organizacionaJedinica).Include(a => a.status).Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    organizacionaJedinica = x.organizacionaJedinica,
                    Status_FK = x.Status_FK,
                    status = x.status
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
                        worksheet.Cell(currentRow, 5).Value = x.status.Naziv;
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

        [Area("User")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "User")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<ProjekatPlan> pp_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).Include(a=>a.organizacionaJedinica).Include(a=>a.status).Select(x => new ProjekatPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    Naziv = x.Naziv,
                    OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    Sifra = x.Sifra,
                    organizacionaJedinica = x.organizacionaJedinica,
                    Status_FK = x.Status_FK,
                    status = x.status
                }).ToList();

                ViewData["proj_plan"] = pp_final;

                return View();
            }
        }
    }
}
