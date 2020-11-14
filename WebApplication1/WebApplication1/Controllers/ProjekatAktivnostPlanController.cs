using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Controllers
{
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }

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
        public IActionResult Unos(int u, int o, int r)
        {
            List<ProjekatPlan> lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
            {
                Naziv=x.Naziv,
                ProjekatPlan_ID=x.ProjekatPlan_ID
            }).ToList();

            ViewData["lista_proj_plan"] = lista_proj_plan;

            return View();
        }
        public IActionResult UnosSnimi(int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina, int u, int o, int r)
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
    }
}