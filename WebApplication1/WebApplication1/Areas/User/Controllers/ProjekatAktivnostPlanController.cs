using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.User.Controllers
{
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("User")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            //List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            //{
            //    Sifra=x.Sifra,
            //    DatumDo=x.DatumDo,
            //    DatumOd=x.DatumOd,
            //    JedinicaMjere=x.JedinicaMjere,
            //    Kolicina=x.Kolicina,
            //    Naziv=x.Naziv,
            //    ProjekatPlan_FK=x.ProjekatPlan_FK,
            //    projekatPlan=db.ProjekatPlan.Where(c=>c.ProjekatPlan_ID==x.ProjekatPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID
            //}).ToList();

            //ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

            List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

            foreach (var x in p_p)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        p_p_final.Add(new ProjekatPlan
                        {
                            DatumDo = x.DatumDo,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                            DatumOd = x.DatumOd,
                            Naziv = x.Naziv,
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            Sifra = x.Sifra
                        });
                    }
                }
            }


            List<ProjekatAktivnostPlan> temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> temp_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in temp)
            {
                foreach (var y in p_p_final)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        temp_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = x.DatumDo,
                            DatumOd = x.DatumOd,
                            JedinicaMjere = x.JedinicaMjere,
                            Naziv = x.Naziv,
                            Kolicina = x.Kolicina,
                            ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                            projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                            ProjekatPlan_FK = x.ProjekatPlan_FK,
                            Sifra = x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = temp_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("User")]
        public IActionResult Unos(int u, int o, int r)
        {
            //List<ProjekatPlan> lista_proj_plan = db.ProjekatPlan.Select(x => new ProjekatPlan
            //{
            //    Naziv=x.Naziv,
            //    ProjekatPlan_ID=x.ProjekatPlan_ID
            //}).ToList();

            //ViewData["lista_proj_plan"] = lista_proj_plan;

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

            foreach (var x in p_p)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        p_p_final.Add(new ProjekatPlan
                        {
                            Naziv = x.Naziv,
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["lista_proj_plan"] = p_p_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("User")]
        public IActionResult UnosSnimi(int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina, int u, int o, int r)
        {
            ProjekatAktivnostPlan temp_2 = new ProjekatAktivnostPlan
            {
                DatumDo=Do,
                DatumOd=Od,
                JedinicaMjere=jedinicaMjere,
                Kolicina=kolicina,
                Naziv=naziv,
                ProjekatPlan_FK=projekatPlan,
                Sifra=sifra
            };

            db.ProjekatAktivnostPlan.Add(temp_2);
            db.SaveChanges();

            //List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            //{
            //    Sifra = x.Sifra,
            //    DatumDo = x.DatumDo,
            //    DatumOd = x.DatumOd,
            //    JedinicaMjere = x.JedinicaMjere,
            //    Kolicina = x.Kolicina,
            //    Naziv = x.Naziv,
            //    ProjekatPlan_FK = x.ProjekatPlan_FK,
            //    projekatPlan = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
            //}).ToList();

            //ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

             List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

            foreach(var x in p_p)
            {
                foreach(var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        p_p_final.Add(new ProjekatPlan
                        {
                            DatumDo=x.DatumDo,
                            OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                            organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault(),
                            DatumOd=x.DatumOd,
                            Naziv=x.Naziv,
                            ProjekatPlan_ID=x.ProjekatPlan_ID,
                            Sifra=x.Sifra
                        });
                    }
                }
            }


            List<ProjekatAktivnostPlan> temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> temp_final = new List<ProjekatAktivnostPlan>();

            foreach(var x in temp)
            {
                foreach(var y in p_p_final)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        temp_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo=x.DatumDo,
                            DatumOd=x.DatumOd,
                            JedinicaMjere=x.JedinicaMjere,
                            Naziv=x.Naziv,
                            Kolicina=x.Kolicina,
                            ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID,
                            projekatPlan=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==x.ProjekatPlan_FK).FirstOrDefault(),
                            ProjekatPlan_FK=x.ProjekatPlan_FK,
                            Sifra=x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = temp_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("User")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            ProjekatAktivnostPlan temp_2 = db.ProjekatAktivnostPlan.Where(x => x.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

            if (temp_2 != null)
            {
                db.ProjekatAktivnostPlan.Remove(temp_2);
                db.SaveChanges();
            }

            //List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            //{
            //    Sifra = x.Sifra,
            //    DatumDo = x.DatumDo,
            //    DatumOd = x.DatumOd,
            //    JedinicaMjere = x.JedinicaMjere,
            //    Kolicina = x.Kolicina,
            //    Naziv = x.Naziv,
            //    ProjekatPlan_FK = x.ProjekatPlan_FK,
            //    projekatPlan = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID
            //}).ToList();

            //ViewData["pro_aktiv_plan"] = lista_pro_aktiv_plan;

            List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

            foreach (var x in p_p)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        p_p_final.Add(new ProjekatPlan
                        {
                            DatumDo = x.DatumDo,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                            DatumOd = x.DatumOd,
                            Naziv = x.Naziv,
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            Sifra = x.Sifra
                        });
                    }
                }
            }


            List<ProjekatAktivnostPlan> temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> temp_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in temp)
            {
                foreach (var y in p_p_final)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        temp_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = x.DatumDo,
                            DatumOd = x.DatumOd,
                            JedinicaMjere = x.JedinicaMjere,
                            Naziv = x.Naziv,
                            Kolicina = x.Kolicina,
                            ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                            projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                            ProjekatPlan_FK = x.ProjekatPlan_FK,
                            Sifra = x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = temp_final;

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