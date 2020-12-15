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

namespace WebApplication1.Areas.AdminOrg.Controllers
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

        [Area("AdminOrg")]
        public IActionResult Excel()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }

            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();
                List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
                List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

                foreach (var x in pp_temp)
                {
                    foreach (var y in org_jed_lista)
                    {
                        if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                        {
                            pp_final.Add(new ProjekatPlan
                            {
                                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                                DatumDo = x.DatumDo,
                                DatumOd = x.DatumOd,
                                Naziv = x.Naziv,
                                organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                                ProjekatPlan_ID = x.ProjekatPlan_ID,
                                Sifra = x.Sifra,
                                status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault(),
                                Status_FK = x.Status_FK
                            });
                        }
                    }
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Projekat_Plan");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Šifra";
                    worksheet.Cell(currentRow, 2).Value = "Naziv";
                    worksheet.Cell(currentRow, 3).Value = "Organizaciona Jedinica";
                    worksheet.Cell(currentRow, 4).Value = "Datum od";
                    worksheet.Cell(currentRow, 5).Value = "Datum do";
                    worksheet.Cell(currentRow, 5).Value = "Status";

                    foreach (var x in pp_final)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.Sifra;
                        worksheet.Cell(currentRow, 2).Value = x.Naziv;
                        worksheet.Cell(currentRow, 3).Value = x.organizacionaJedinica.Naziv;
                        worksheet.Cell(currentRow, 4).Value = x.DatumOd;
                        worksheet.Cell(currentRow, 5).Value = x.DatumDo;
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

        [Area("AdminOrg")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();
                List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
                List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

                foreach (var x in pp_temp)
                {
                    foreach (var y in org_jed_lista)
                    {
                        if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                        {
                            pp_final.Add(new ProjekatPlan
                            {
                                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                                DatumDo = x.DatumDo,
                                DatumOd = x.DatumOd,
                                Naziv = x.Naziv,
                                organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                                ProjekatPlan_ID = x.ProjekatPlan_ID,
                                Sifra = x.Sifra,
                                Status_FK = x.Status_FK,
                                status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                            });
                        }
                    }
                }
                ViewData["proj_plan"] = pp_final;

                return View();
            }
        }
        [Area("AdminOrg")]
        public IActionResult Unos()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<OrganizacionaJedinica> lista_org_jed = new List<OrganizacionaJedinica>();

                List<OrganizacionaJedinica> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

                foreach (var x in org)
                {
                    if (x.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID"))
                    {
                        lista_org_jed.Add(new OrganizacionaJedinica
                        {
                            Adresa = x.Adresa,
                            drzava = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).FirstOrDefault(),
                            Drzava_FK = x.Drzava_FK,
                            Naziv = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Select(p => p.Naziv).FirstOrDefault(),
                            organizacija = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).FirstOrDefault(),
                            Organizacija_FK = x.Organizacija_FK,
                            OrganizacionaJedinica_ID = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Select(p => p.OrganizacionaJedinica_ID).FirstOrDefault(),
                            ptt = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).FirstOrDefault(),
                            PTT_FK = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(p => p.PTT_ID).FirstOrDefault()
                        });
                    }
                }

                ViewData["lista_org_jed"] = org;

                List<Status> stat_lista = db.Status.ToList();
                ViewData["statusi"] = stat_lista;

                return View();
            }
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int organizacionaJedinica, int sifra, string naziv, DateTime Od, DateTime Do, int status_id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan temp = new ProjekatPlan
                {
                    DatumDo = Do,
                    DatumOd = Od,
                    Naziv = naziv,
                    OrganizacionaJedinica_FK = organizacionaJedinica,
                    Sifra = sifra,
                    Status_FK = status_id
                };

                db.ProjekatPlan.Add(temp);
                db.SaveChanges();

                List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();
                List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
                List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

                foreach (var x in pp_temp)
                {
                    foreach (var y in org_jed_lista)
                    {
                        if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                        {
                            pp_final.Add(new ProjekatPlan
                            {
                                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                                DatumDo = x.DatumDo,
                                DatumOd = x.DatumOd,
                                Naziv = x.Naziv,
                                organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                                ProjekatPlan_ID = x.ProjekatPlan_ID,
                                Sifra = x.Sifra,
                                Status_FK = x.Status_FK,
                                status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                            });
                        }
                    }
                }
                ViewData["proj_plan"] = pp_final;

                return View("Prikaz");
            }
        }
        [Area("AdminOrg")]
        public IActionResult Ukloni(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan temp = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.ProjekatPlan.Remove(temp);
                    db.SaveChanges();
                }


                List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();
                List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
                List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

                foreach (var x in pp_temp)
                {
                    foreach (var y in org_jed_lista)
                    {
                        if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                        {
                            pp_final.Add(new ProjekatPlan
                            {
                                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                                DatumDo = x.DatumDo,
                                DatumOd = x.DatumOd,
                                Naziv = x.Naziv,
                                organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                                ProjekatPlan_ID = x.ProjekatPlan_ID,
                                Sifra = x.Sifra,
                                Status_FK = x.Status_FK,
                                status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                            });
                        }
                    }
                }
                ViewData["proj_plan"] = pp_final;

                return View("Prikaz");
            }
        }

        [Area("AdminOrg")]
        public IActionResult Uredi(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                List<OrganizacionaJedinica> lista_org_jed = new List<OrganizacionaJedinica>();

                List<OrganizacionaJedinica> org = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

                foreach (var x in org)
                {
                    if (x.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID"))
                    {
                        lista_org_jed.Add(new OrganizacionaJedinica
                        {
                            Adresa = x.Adresa,
                            drzava = db.Drzava.Where(a => a.Drzava_ID == x.Drzava_FK).FirstOrDefault(),
                            Drzava_FK = x.Drzava_FK,
                            Naziv = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Select(p => p.Naziv).FirstOrDefault(),
                            organizacija = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).FirstOrDefault(),
                            Organizacija_FK = x.Organizacija_FK,
                            OrganizacionaJedinica_ID = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Select(p => p.OrganizacionaJedinica_ID).FirstOrDefault(),
                            ptt = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).FirstOrDefault(),
                            PTT_FK = db.PTT.Where(a => a.PTT_ID == x.PTT_FK).Select(p => p.PTT_ID).FirstOrDefault()
                        });
                    }
                }

                ViewData["org_jed"] = org;

                ProjekatPlan p = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();
                p.organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == p.OrganizacionaJedinica_FK).FirstOrDefault();
                ViewData["projekat"] = p;

                List<Status> stat_lista = db.Status.ToList();
                ViewData["statusi"] = stat_lista;

                return View();
            }
        }

        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int id, DateTime DO, DateTime OD, string naziv, int org_jed, int sifra, int status_id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "Admin-Org")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ProjekatPlan t = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == id).FirstOrDefault();

                t.DatumDo = DO;
                t.DatumOd = OD;
                t.Naziv = naziv;
                t.OrganizacionaJedinica_FK = org_jed;
                t.Sifra = sifra;
                t.Status_FK = status_id;

                db.SaveChanges();


                List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();
                List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
                List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

                foreach (var x in pp_temp)
                {
                    foreach (var y in org_jed_lista)
                    {
                        if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                        {
                            pp_final.Add(new ProjekatPlan
                            {
                                OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                                DatumDo = x.DatumDo,
                                DatumOd = x.DatumOd,
                                Naziv = x.Naziv,
                                organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                                ProjekatPlan_ID = x.ProjekatPlan_ID,
                                Sifra = x.Sifra,
                                Status_FK = x.Status_FK,
                                status = db.Status.Where(a => a.StatusID == x.Status_FK).FirstOrDefault()
                            });
                        }
                    }
                }
                ViewData["proj_plan"] = pp_final;

                return View("Prikaz");
            }
        }
    }
}