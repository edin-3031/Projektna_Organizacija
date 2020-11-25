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

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class ProjekatPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Excel()
        {

            List<ProjekatPlan> proj_plan = db.ProjekatPlan.Select(x=>new ProjekatPlan { 
                DatumDo=x.DatumDo,
                DatumOd=x.DatumOd,
                Naziv=x.Naziv,
                status=db.Status.Where(a=>a.StatusID==x.Status_FK).FirstOrDefault(),
                Status_FK=x.Status_FK,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault(),
                OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                ProjekatPlan_ID=x.ProjekatPlan_ID,
                Sifra=x.Sifra
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
                    worksheet.Cell(currentRow, 6).Value = db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID== x.OrganizacionaJedinica_FK).Select(o=>o.Naziv).FirstOrDefault();
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

        [Area("SuperAdmin")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            List<ProjekatPlan> lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
            {
                DatumDo=x.DatumDo,
                DatumOd=x.DatumOd,
                Naziv=x.Naziv,
                OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                ProjekatPlan_ID=x.ProjekatPlan_ID,
                Sifra=x.Sifra,
                organizacionaJedinica=db.OrganizacionaJedinica.Where(d=>d.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault(),
                Status_FK=x.Status_FK,
                status=db.Status.Where(a=>a.StatusID==x.Status_FK).FirstOrDefault()
            }).ToList();

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;


            ViewData["proj_plan"] = lista_proj_plan;

            return View();
        }
        [Area("SuperAdmin")]
        public IActionResult Unos(int u, int o, int r)
        {
            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Select(x => new OrganizacionaJedinica
            {
                Naziv=x.Naziv,
                organizacija=db.Organizacija.Where(v=>v.Organizacija_ID==x.Organizacija_FK).FirstOrDefault(),
                drzava=db.Drzava.Where(v=>v.Drazava_ID==x.Drzava_FK).FirstOrDefault(),
                ptt=db.PTT.Where(v=>v.PTT_ID==x.PTT_FK).FirstOrDefault(),
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID
            }).ToList();

            ViewData["lista_org_jed"] = lista_org_jed;

            List<Status> stat_lista = db.Status.ToList();
            ViewData["statusi"] = stat_lista;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;


            return View();
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int organizacionaJedinica, int sifra, string naziv, DateTime Od, DateTime Do, int u, int o, int r, int status_id)
        {
            ProjekatPlan temp = new ProjekatPlan
            {
                DatumDo = Do,
                DatumOd = Od,
                Naziv = naziv,
                OrganizacionaJedinica_FK = organizacionaJedinica,
                Sifra = sifra,
                Status_FK=status_id
            };

            db.ProjekatPlan.Add(temp);
            db.SaveChanges();

            List<ProjekatPlan> lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
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
            ViewData["proj_plan"] = lista_proj_plan;


            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("SuperAdmin")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            ProjekatPlan temp = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == id).FirstOrDefault();

            if (temp != null)
            {
                db.ProjekatPlan.Remove(temp);
                db.SaveChanges();
            }

            List<ProjekatPlan> lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
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
            ViewData["proj_plan"] = lista_proj_plan;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;


            return View("Prikaz");
        }

        [Area("SuperAdmin")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.ToList();

            ViewData["org_jed"] = org_jed_lista;

            ProjekatPlan p = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();
            p.organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == p.OrganizacionaJedinica_FK).FirstOrDefault();
            p.status = db.Status.Where(a => a.StatusID == p.Status_FK).FirstOrDefault();
            ViewData["projekat"] = p;

            List<Status> stat_lista = db.Status.ToList();
            ViewData["statusi"] = stat_lista;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, int u, int o, int r, DateTime DO, DateTime OD, string naziv, int org_jed, int sifra, int status_id)
        {
            ProjekatPlan t = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();

            t.DatumDo=DO;
            t.DatumOd=OD;
            t.Naziv = naziv;
            t.OrganizacionaJedinica_FK = org_jed;
            t.Sifra = sifra;
            t.Status_FK = status_id;

            db.SaveChanges();

            List < ProjekatPlan > lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
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

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;


            ViewData["proj_plan"] = lista_proj_plan;

            return View("Prikaz");
        }
    }
}
