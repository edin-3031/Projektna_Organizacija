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

namespace WebApplication1.Areas.User.Controllers
{
    public class ProjekatAktivnostPlanController : Controller
    {
        private readonly ApplicationDbContext db;
        string poruka = "Morate se ponovo prijaviti";
        string poruka2 = "Nemate pravo pristupa";

        public ProjekatAktivnostPlanController(ApplicationDbContext _db)
        {
            db = _db;
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

                return View();
            }
        }
        [Area("User")]
        public IActionResult Unos()
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

                List<ProjekatPlan> p_p_final = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                ViewData["lista_proj_plan"] = p_p_final;

                return View();
            }
        }
        [Area("User")]
        public IActionResult UnosSnimi(int projekatPlan, int sifra, string naziv, DateTime Od, DateTime Do, string jedinicaMjere, float kolicina)
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

                ProjekatAktivnostPlan temp_2 = new ProjekatAktivnostPlan
                {
                    DatumDo = Do,
                    DatumOd = Od,
                    JedinicaMjere = jedinicaMjere,
                    Kolicina = kolicina,
                    Naziv = naziv,
                    ProjekatPlan_FK = projekatPlan,
                    Sifra = sifra
                };

                db.ProjekatAktivnostPlan.Add(temp_2);
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
        }
        [Area("User")]
        public IActionResult Ukloni(int id)
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

                ProjekatAktivnostPlan temp_2 = db.ProjekatAktivnostPlan.Where(x => x.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

                if (temp_2 != null)
                {
                    db.ProjekatAktivnostPlan.Remove(temp_2);
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
        }

        [Area("User")]
        public IActionResult Uredi(int id)
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

                ProjekatAktivnostPlan aktivnost = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();
                aktivnost.projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == aktivnost.ProjekatPlan_FK).FirstOrDefault();

                ViewData["aktiv"] = aktivnost;

                return View();
            }
        }

        [Area("User")]
        public IActionResult UrediSnimi(int id, DateTime OD, DateTime DO, string jedinicaMjere, float kolicina, string naziv, int projekatPlanId, int sifra)
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

                ProjekatAktivnostPlan aktivnost = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == id).FirstOrDefault();

                aktivnost.DatumDo = DO;
                aktivnost.DatumOd = OD;
                aktivnost.JedinicaMjere = jedinicaMjere;
                aktivnost.Kolicina = kolicina;
                aktivnost.Naziv = naziv;
                aktivnost.ProjekatPlan_FK = projekatPlanId;
                aktivnost.Sifra = sifra;

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
                        worksheet.Cell(currentRow, 4).Value = x.DatumOd.Date.Day + "." + x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".";
                        worksheet.Cell(currentRow, 5).Value = x.DatumDo.Date.Day + "." + x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".";
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
        }
    }
}