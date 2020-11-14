using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class ProjekatPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("Admin")]
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
                organizacionaJedinica=db.OrganizacionaJedinica.Where(d=>d.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault()
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
        [Area("Admin")]
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
        public IActionResult UnosSnimi(int organizacionaJedinica, int sifra, string naziv, DateTime Od, DateTime Do, int u, int o, int r)
        {
            ProjekatPlan temp = new ProjekatPlan
            {
                DatumDo = Do,
                DatumOd = Od,
                Naziv = naziv,
                OrganizacionaJedinica_FK = organizacionaJedinica,
                Sifra = sifra
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
                organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
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
        [Area("Admin")]
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
                organizacionaJedinica = db.OrganizacionaJedinica.Where(d => d.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
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
    }
}
