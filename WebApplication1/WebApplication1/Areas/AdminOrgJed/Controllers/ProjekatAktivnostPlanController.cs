using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.AdminOrgJed.Controllers
{
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("AdminOrgJed")]
        public IActionResult Excel()
        {
            List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> pap_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_temp)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        pap_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = x.DatumDo,
                            ProjekatPlan_FK = x.ProjekatPlan_FK,
                            DatumOd = x.DatumOd,
                            JedinicaMjere = x.JedinicaMjere,
                            Kolicina = x.Kolicina,
                            Naziv = x.Naziv,
                            ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                            projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                            Sifra = x.Sifra
                        });
                    }
                }
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ProjektneAktivnosti");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Naziv";
                worksheet.Cell(currentRow, 2).Value = "Šifra";
                worksheet.Cell(currentRow, 3).Value = "Projekat plan";
                worksheet.Cell(currentRow, 4).Value = "Datum od";
                worksheet.Cell(currentRow, 5).Value = "Datum do";
                worksheet.Cell(currentRow, 6).Value = "Količina";
                worksheet.Cell(currentRow, 7).Value = "Jedinica mjere";

                foreach (var x in pap_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Naziv;
                    worksheet.Cell(currentRow, 2).Value = x.Sifra;
                    worksheet.Cell(currentRow, 3).Value = x.projekatPlan.Naziv.ToString();
                    worksheet.Cell(currentRow, 4).Value = x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".";
                    worksheet.Cell(currentRow, 5).Value = x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".";
                    worksheet.Cell(currentRow, 6).Value = x.Kolicina;
                    worksheet.Cell(currentRow, 7).Value = x.JedinicaMjere;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ProjektneAktivnostiInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        [Area("AdminOrgJed")]
        public IActionResult Prikaz()
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();



            List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> pap_final= new List<ProjekatAktivnostPlan>();

            foreach(var x in pap_temp)
            {
                foreach(var y in pp_temp)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        pap_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo=x.DatumDo,
                            ProjekatPlan_FK=x.ProjekatPlan_FK,
                            DatumOd=x.DatumOd,
                            JedinicaMjere=x.JedinicaMjere,
                            Kolicina=x.Kolicina,
                            Naziv=x.Naziv,
                            ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID,
                            projekatPlan=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==x.ProjekatPlan_FK).FirstOrDefault(),
                            Sifra=x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = pap_final;

            return View();
        }
        [Area("AdminOrgJed")]
        public IActionResult Unos()
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();



            List<ProjekatPlan> p_p_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

            ViewData["lista_proj_plan"] = p_p_final;

            return View();
        }
        [Area("AdminOrgJed")]
        public IActionResult UnosSnimi(int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

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


            List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> pap_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_temp)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        pap_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = x.DatumDo,
                            ProjekatPlan_FK = x.ProjekatPlan_FK,
                            DatumOd = x.DatumOd,
                            JedinicaMjere = x.JedinicaMjere,
                            Kolicina = x.Kolicina,
                            Naziv = x.Naziv,
                            ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                            projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                            Sifra = x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = pap_final;

            return View("Prikaz");
        }
        [Area("AdminOrgJed")]
        public IActionResult Ukloni(int id)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            ProjekatAktivnostPlan temp = db.ProjekatAktivnostPlan.Where(x => x.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

            if (temp != null)
            {
                db.ProjekatAktivnostPlan.Remove(temp);
                db.SaveChanges();
            }


            List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> pap_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_temp)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        pap_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = x.DatumDo,
                            ProjekatPlan_FK = x.ProjekatPlan_FK,
                            DatumOd = x.DatumOd,
                            JedinicaMjere = x.JedinicaMjere,
                            Kolicina = x.Kolicina,
                            Naziv = x.Naziv,
                            ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                            projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                            Sifra = x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = pap_final;

            return View("Prikaz");
        }
        [Area("AdminOrgJed")]
        public IActionResult Uredi(int id)
        {
            ProjekatAktivnostPlan pap = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();
            pap.projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == pap.ProjekatPlan_FK).FirstOrDefault();
            ViewData["projekatAktivnostPlan"] = pap;

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();
            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

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

            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            return View();
        }
        [Area("AdminOrgJed")]
        public IActionResult UrediSnimi(int id, DateTime DO, DateTime OD, string jedinicaMjere, float kolicina, string naziv, int sifra, int projekatPlanId)
        {

            ProjekatAktivnostPlan p = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

            p.DatumDo = DO;
            p.DatumOd = OD;
            p.JedinicaMjere = jedinicaMjere;
            p.Kolicina = kolicina;
            p.Naziv = naziv;
            p.ProjekatPlan_FK = projekatPlanId;
            p.Sifra = sifra;

            db.SaveChanges();


            List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> pap_final = new List<ProjekatAktivnostPlan>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_temp)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        pap_final.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = x.DatumDo,
                            ProjekatPlan_FK = x.ProjekatPlan_FK,
                            DatumOd = x.DatumOd,
                            JedinicaMjere = x.JedinicaMjere,
                            Kolicina = x.Kolicina,
                            Naziv = x.Naziv,
                            ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                            projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                            Sifra = x.Sifra
                        });
                    }
                }
            }

            ViewData["pro_aktiv_plan"] = pap_final;

            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            return View("Prikaz");
        }
    }
}