using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("Admin")]
        public IActionResult Excel()
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

        [Area("Admin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            {
                Sifra=x.Sifra,
                DatumDo=x.DatumDo,
                DatumOd=x.DatumOd,
                JedinicaMjere=x.JedinicaMjere,
                Kolicina=x.Kolicina,
                Naziv=x.Naziv,
                ProjekatPlan_FK=x.ProjekatPlan_FK,
                projekatPlan=db.ProjekatPlan.Where(c=>c.ProjekatPlan_ID==x.ProjekatPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID
            }).ToList();

            ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("Admin")]
        public IActionResult Unos(int u, int o, int r)
        {
            List<ProjekatPlan> lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
            {
                Naziv=x.Naziv,
                ProjekatPlan_ID=x.ProjekatPlan_ID,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID== x.OrganizacionaJedinica_FK).FirstOrDefault()
            }).ToList();

            ViewData["lista_proj_plan"] = lista_proj_plan;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("Admin")]
        public IActionResult UnosSnimi(int u, int o, int r,int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina)
        {
            ProjekatAktivnostPlan temp = new ProjekatAktivnostPlan
            {
                DatumDo=Do,
                DatumOd=Od,
                JedinicaMjere=jedinicaMjere,
                Kolicina=kolicina,
                Naziv=naziv,
                ProjekatPlan_FK=projekatPlan,
                Sifra=sifra
            };

            db.ProjekatAktivnostPlan.Add(temp);
            db.SaveChanges();

            List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            {
                Sifra = x.Sifra,
                DatumDo = x.DatumDo,
                DatumOd = x.DatumOd,
                JedinicaMjere = x.JedinicaMjere,
                Kolicina = x.Kolicina,
                Naziv = x.Naziv,
                ProjekatPlan_FK = x.ProjekatPlan_FK,
                projekatPlan = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
            }).ToList();

            ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

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
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            ProjekatAktivnostPlan temp = db.ProjekatAktivnostPlan.Where(x => x.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

            if (temp != null)
            {
                db.ProjekatAktivnostPlan.Remove(temp);
                db.SaveChanges();
            }

            List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            {
                Sifra = x.Sifra,
                DatumDo = x.DatumDo,
                DatumOd = x.DatumOd,
                JedinicaMjere = x.JedinicaMjere,
                Kolicina = x.Kolicina,
                Naziv = x.Naziv,
                ProjekatPlan_FK = x.ProjekatPlan_FK,
                projekatPlan = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
            }).ToList();

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

            return View("Prikaz");
        }
    }
}