using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.AdminOrg.Controllers
{
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("AdminOrg")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

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
                userId = u,
                organisationId = o,
                roleId = r
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult Unos(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

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
                userId = u,
                organisationId = o,
                roleId = r
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

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


            List<ProjekatAktivnostPlan> temp_2 = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> temp_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in temp_2)
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
                userId = u,
                organisationId = o,
                roleId = r
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            ProjekatAktivnostPlan temp = db.ProjekatAktivnostPlan.Where(x => x.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

            if (temp != null)
            {
                db.ProjekatAktivnostPlan.Remove(temp);
                db.SaveChanges();
            }

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


            List<ProjekatAktivnostPlan> temp_2 = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> temp_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in temp_2)
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
                userId = u,
                organisationId = o,
                roleId = r
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            ProjekatAktivnostPlan pap = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();
            pap.projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == pap.ProjekatPlan_FK).FirstOrDefault();
            ViewData["projekatAktivnostPlan"] = pap;

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();
            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

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
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                        });
                    }
                }
            }

            ViewData["lista_proj_plan"] = p_p_final;

            uor podaci = new uor
            {
                userId = u,
                organisationId = o,
                roleId = r
            };
            ViewData["id"] = podaci;

            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();
            ViewData["logo"] = logo;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int id, int u, int o, int r, DateTime DO, DateTime OD, string jedinicaMjere, float kolicina, string naziv, int projekatPlan_id, int sifra)
        {
            ProjekatAktivnostPlan p = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

            p.DatumDo = DO;
            p.DatumOd = OD;
            p.JedinicaMjere = jedinicaMjere;
            p.Kolicina = kolicina;
            p.Naziv = naziv;
            p.ProjekatPlan_FK = projekatPlan_id;
            p.Sifra = sifra;

            db.SaveChanges();

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
                userId = u,
                organisationId = o,
                roleId = r
            };
            ViewData["id"] = podaci;

            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();
            ViewData["logo"] = logo;

            return View("Prikaz");
        }
    }
}