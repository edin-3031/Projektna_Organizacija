﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Misc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Hosting;
using SelectPdf;
using Aspose.Pdf;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class ProjekatAktivnostRealizacijaController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";


        public ProjekatAktivnostRealizacijaController(ApplicationDbContext _db)
        {
            db = _db;

        }
        [Area("SuperAdmin")]
        public IActionResult Pdf()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }

            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                var document = new Document
                {
                    PageInfo = new PageInfo
                    {
                        Margin = new MarginInfo(28, 28, 28, 40)
                    }
                };
                var pdfpage = document.Pages.Add();
                Table table = new Table
                {
                    ColumnWidths = "25% 25% 25% 25%",
                    DefaultCellPadding = new MarginInfo(10, 5, 10, 5),
                    Border = new BorderInfo(BorderSide.All, .5f, Color.Black),
                    DefaultCellBorder = new BorderInfo(BorderSide.All, .2f, Color.Black),
                };

                DataTable GetRecord()
                {
                    //List<ProjekatAktivnostRealizacija> _real = db.ProjekatAktivnostRealizacija.ToList();

                    //List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();
                    //foreach (var x in _real)
                    //{
                    //    _lista.Add(new DetaljiRealizacijaVM
                    //    {
                    //        datum = x.Datum,
                    //        idAktivnost = x.ProjekatAktivnostPlan_FK,
                    //        idProjekat = db.ProjekatPlan.Where(s => s.ProjekatPlan_ID == db.ProjekatAktivnostPlan.Where(a => a.ProjekatPlan_FK == x.ProjekatAktivnostPlan_FK).Select(o => o.ProjekatPlan_FK).FirstOrDefault()).Select(o => o.ProjekatPlan_ID).FirstOrDefault(),
                    //        idRealizacija = x.ProjekatAktivnostRealizacija_ID,
                    //        idUser = x.Korisnici_FK,
                    //        kolicina = x.Kolicina,
                    //        korisnik = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime.ToString() + " " + o.Prezime.ToString()).FirstOrDefault(),
                    //        NazivAktivnosti = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                    //        //NazivProjekta = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).Select(o => o.projekatPlan.Naziv).FirstOrDefault(),
                    //        opis = x.Opis

                    //    });
                    //}

                    //lista_DetaljiRealizacijaVM model = new lista_DetaljiRealizacijaVM
                    //{
                    //    lista = _lista
                    //};

                    SqlConnection con = new SqlConnection("server=127.0.0.1;port=3306;database=ProjektnaOrganizacija;user=root;password=3031_elemeNtaL_3031;");

                    SqlCommand com = new SqlCommand("select * from projekataktivnostrealizacija", con);

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }

                DataTable dt = GetRecord();
                table.ImportDataTable(dt, true, 0, 0);
                document.Pages[1].Paragraphs.Add(table);

                using (var streamout = new MemoryStream())
                {
                    document.Save(streamout);
                    return new FileContentResult(streamout.ToArray(), "application/pdf")
                    {
                        FileDownloadName = "Realizacija.pdf"
                    };
                }
            }
        }

        //public IActionResult Pdf(string html)
        //{
        //    html = html.Replace("StrTag", "<").Replace("EndTag", ">");

        //    HtmlToPdf oHtmlToPdf = new HtmlToPdf();
        //    PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(html);
        //    byte[] pdf = oPdfDocument.Save();
        //    oPdfDocument.Close();

        //    return File(
        //        pdf,
        //        "application/pdf",
        //        "Realizacija.pdf"
        //        );
        //}
        [Area("SuperAdmin")]
        public IActionResult Excel()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<ProjekatAktivnostRealizacija> _real = db.ProjekatAktivnostRealizacija.ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Realizacija");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Realizacija ID";
                    worksheet.Cell(currentRow, 2).Value = "Aktivnost_ID";
                    worksheet.Cell(currentRow, 3).Value = "Korisnik_ID";
                    worksheet.Cell(currentRow, 4).Value = "Korisnik";
                    worksheet.Cell(currentRow, 5).Value = "Datum";
                    worksheet.Cell(currentRow, 6).Value = "Količina";
                    worksheet.Cell(currentRow, 7).Value = "Opis";

                    foreach (var x in _real)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.ProjekatAktivnostRealizacija_ID;
                        worksheet.Cell(currentRow, 2).Value = x.ProjekatAktivnostPlan_FK;
                        worksheet.Cell(currentRow, 3).Value = x.Korisnici_FK;
                        worksheet.Cell(currentRow, 4).Value = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime.ToString() + " " + o.Prezime.ToString()).FirstOrDefault();
                        worksheet.Cell(currentRow, 5).Value = x.Datum.Date;
                        worksheet.Cell(currentRow, 6).Value = x.Kolicina;
                        worksheet.Cell(currentRow, 7).Value = x.Opis;
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "RealizacijaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                    }
                }
            }
        }
        [Area("SuperAdmin")]
        public IActionResult PrintPreview()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<ProjekatAktivnostRealizacija> _real = db.ProjekatAktivnostRealizacija.ToList();

                List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();
                foreach (var x in _real)
                {
                    _lista.Add(new DetaljiRealizacijaVM
                    {
                        datum = x.Datum,
                        idAktivnost = x.ProjekatAktivnostPlan_FK,
                        idProjekat = db.ProjekatPlan.Where(s => s.ProjekatPlan_ID == db.ProjekatAktivnostPlan.Where(a => a.ProjekatPlan_FK == x.ProjekatAktivnostPlan_FK).Select(o => o.ProjekatPlan_FK).FirstOrDefault()).Select(o => o.ProjekatPlan_ID).FirstOrDefault(),
                        idRealizacija = x.ProjekatAktivnostRealizacija_ID,
                        idUser = x.Korisnici_FK,
                        kolicina = x.Kolicina,
                        korisnik = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime.ToString() + " " + o.Prezime.ToString()).FirstOrDefault(),
                        NazivAktivnosti = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                        //NazivProjekta = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).Select(o => o.projekatPlan.Naziv).FirstOrDefault(),
                        opis = x.Opis

                    });
                }

                lista_DetaljiRealizacijaVM model = new lista_DetaljiRealizacijaVM
                {
                    lista = _lista
                };

                return View(model);
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Detalji(int projekatId = 0, DateTime? OD = null, DateTime? DO = null, int traziDugme = 0)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                //Dobavljanje liste projekata za birajuću listu
                List<ProjekatPlanVM> projekti = db.ProjekatPlan.Include(a => a.organizacionaJedinica).Select(x => new ProjekatPlanVM
                {
                    Naziv = x.Naziv,
                    ProjekatPlan_ID = x.ProjekatPlan_ID,
                    OrganizacionaJedinica_id = x.OrganizacionaJedinica_FK,
                    OrganizacionaJedinica_naziv = x.organizacionaJedinica.Naziv,
                }).ToList();

                ViewData["projekti"] = projekti;

                if (projekatId == 0 && (OD != null || DO != null))
                {
                    List<ProjekatAktivnostRealizacijaVM> par = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Include(a => a.projekatAktivnostPlan.projekatPlan).Select(x => new ProjekatAktivnostRealizacijaVM
                    {
                        Datum = x.Datum,
                        Kolicina = x.Kolicina,
                        Korisnici_id = x.korisnici.Korisnici_ID,
                        Korisnici_naziv = x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString(),
                        ProjekatAktivnostPlan_id = x.projekatAktivnostPlan.ProjekatAktivnostPlan_ID,
                        ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                        ProjekatPlan_id = x.projekatAktivnostPlan.projekatPlan.ProjekatPlan_ID,
                        ProjekatPlan_naziv = x.projekatAktivnostPlan.projekatPlan.Naziv,
                        Opis = x.Opis,
                        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                        OrgJed_id=x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                        OrgJed_naziv=x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv
                    }).ToList();

                    //List<RealizacijaVM> lista = new List<RealizacijaVM>();

                    if (OD != null && DO != null)
                    {

                        List<RealizacijaVM> lista = new List<RealizacijaVM>();
                        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                        List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                        foreach (var x in par)
                        {
                            bool povecan = false;

                            if (lista.Count == 0)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                                lista_temp.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                            }
                            else
                            {
                                foreach (var t in lista)
                                {
                                    if (t.aktivnostId == x.ProjekatAktivnostPlan_id)
                                    {
                                        t.odradjeno += x.Kolicina;
                                        povecan = true;
                                        break;
                                    }
                                }
                                if (!povecan)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_id,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_id,
                                        naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatPlan_id,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                            }
                        }

                        foreach (var x in lista)
                        {
                            if ((x.datum.Year <= DO.Value.Year && x.datum.Year >= OD.Value.Year) ||
                                ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month <= DO.Value.Month && x.datum.Month >= OD.Value.Month)) ||
                                ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month == DO.Value.Month && x.datum.Month == OD.Value.Month) && (x.datum.Day <= DO.Value.Day && x.datum.Day >= OD.Value.Day)))
                            {
                                lista_final.Add(new RealizacijaVM
                                {
                                    datum = x.datum,
                                    aktivnostId = x.aktivnostId,
                                    korisnikId = x.korisnikId,
                                    nazivProjekta = x.nazivProjekta,
                                    naziv_aktivnosti = x.naziv_aktivnosti,
                                    odradjeno = x.odradjeno,
                                    planirano = x.planirano,
                                    projekatId = x.projekatId,
                                    realizacijaId = x.realizacijaId
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista_final,
                            Do = DO.Value,
                            Od = OD.Value,
                            organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                            projekat_Id = projekatId
                        };

                        return View(model);
                    }
                    else if (DO != null)
                    {


                        List<RealizacijaVM> lista = new List<RealizacijaVM>();
                        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                        List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                        foreach (var x in par)
                        {
                            bool povecan = false;

                            if (lista.Count == 0)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                                lista_temp.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                            }
                            else
                            {
                                foreach (var t in lista)
                                {
                                    if (t.aktivnostId == x.ProjekatAktivnostPlan_id)
                                    {
                                        t.odradjeno += x.Kolicina;
                                        povecan = true;
                                        break;
                                    }
                                }
                                if (!povecan)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_id,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_id,
                                        naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatPlan_id,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                            }
                        }

                        foreach (var x in lista)
                        {
                            if (x.datum.Year <= DO.Value.Year && x.datum.Month <= DO.Value.Month && x.datum.Day <= DO.Value.Day)
                            {
                                lista_final.Add(new RealizacijaVM
                                {
                                    datum = x.datum,
                                    aktivnostId = x.aktivnostId,
                                    korisnikId = x.korisnikId,
                                    nazivProjekta = x.nazivProjekta,
                                    naziv_aktivnosti = x.naziv_aktivnosti,
                                    odradjeno = x.odradjeno,
                                    planirano = x.planirano,
                                    projekatId = x.projekatId,
                                    realizacijaId = x.realizacijaId
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista_final,
                            Do = DO.Value,
                            organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                            projekat_Id = projekatId
                        };

                        return View(model);
                    }
                    else if (OD != null)
                    {

                        List<RealizacijaVM> lista = new List<RealizacijaVM>();
                        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                        List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                        foreach (var x in par)
                        {
                            bool povecan = false;

                            if (lista.Count == 0)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                                lista_temp.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                            }
                            else
                            {
                                foreach (var t in lista)
                                {
                                    if (t.aktivnostId == x.ProjekatPlan_id)
                                    {
                                        t.odradjeno += x.Kolicina;
                                        povecan = true;
                                        break;
                                    }
                                }
                                if (!povecan)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_id,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_id,
                                        naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatPlan_id,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                            }
                        }

                        foreach (var x in lista)
                        {
                            if (x.datum.Year >= OD.Value.Year && x.datum.Month >= OD.Value.Month && x.datum.Day >= OD.Value.Day)
                            {
                                lista_final.Add(new RealizacijaVM
                                {
                                    datum = x.datum,
                                    aktivnostId = x.aktivnostId,
                                    korisnikId = x.korisnikId,
                                    nazivProjekta = x.nazivProjekta,
                                    naziv_aktivnosti = x.naziv_aktivnosti,
                                    odradjeno = x.odradjeno,
                                    planirano = x.planirano,
                                    projekatId = x.projekatId,
                                    realizacijaId = x.realizacijaId
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista_final,
                            Od = OD.Value,
                            organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                            projekat_Id = projekatId
                        };

                        return View(model);
                    }
                }

                else if (projekatId == 0 && (OD != null && DO != null))
                {
                    List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
                    {
                        Datum = x.Datum,
                        Kolicina = x.Kolicina,
                        korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                        Korisnici_FK = x.Korisnici_FK,
                        Opis = x.Opis,
                        projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                        ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                    }).ToList();

                    List<RealizacijaVM> lista = new List<RealizacijaVM>();
                    List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                    List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                    foreach (var x in par)
                    {
                        bool povecan = false;

                        if (lista.Count == 0)
                        {
                            lista.Add(new RealizacijaVM
                            {
                                aktivnostId = x.ProjekatAktivnostPlan_FK,
                                datum = x.Datum,
                                korisnikId = x.Korisnici_FK,
                                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                odradjeno = x.Kolicina,
                                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                projekatId = x.ProjekatAktivnostPlan_FK,
                                realizacijaId = x.ProjekatAktivnostRealizacija_ID
                            });
                            lista_temp.Add(new RealizacijaVM
                            {
                                aktivnostId = x.ProjekatAktivnostPlan_FK,
                                datum = x.Datum,
                                korisnikId = x.Korisnici_FK,
                                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                odradjeno = x.Kolicina,
                                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                projekatId = x.ProjekatAktivnostPlan_FK,
                                realizacijaId = x.ProjekatAktivnostRealizacija_ID
                            });
                        }
                        else
                        {
                            foreach (var t in lista)
                            {
                                if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
                                {
                                    t.odradjeno += x.Kolicina;
                                    povecan = true;
                                    break;
                                }
                            }
                            if (!povecan)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_FK,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_FK,
                                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatAktivnostPlan_FK,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                            }
                        }
                    }

                    foreach (var x in lista)
                    {

                        lista_final.Add(new RealizacijaVM
                        {
                            datum = x.datum,
                            aktivnostId = x.aktivnostId,
                            korisnikId = x.korisnikId,
                            nazivProjekta = x.nazivProjekta,
                            naziv_aktivnosti = x.naziv_aktivnosti,
                            odradjeno = x.odradjeno,
                            planirano = x.planirano,
                            projekatId = x.projekatId,
                            realizacijaId = x.realizacijaId
                        });

                    }

                    lista_realizacijaVM model = new lista_realizacijaVM
                    {
                        liste = lista_final,
                        Do = DO.Value,
                        Od = OD.Value,
                        organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                        projekat_Id = projekatId
                    };

                    ViewData["lista_projekata"] = lista;
                    return View(model);
                }

                else if (projekatId >= 1)
                {
                    ProjekatPlan p_temp = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == projekatId).FirstOrDefault();
                    OrganizacionaJedinica o_j_temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == p_temp.OrganizacionaJedinica_FK).FirstOrDefault();

                    RealizacijaDetaljiSuma suma = new RealizacijaDetaljiSuma
                    {
                        naziv_projekta = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == projekatId).Select(o => o.Naziv).FirstOrDefault(),
                        ostvareno = 0,
                        planirano = 0,
                        procenti = 0,
                        ProjekatId = projekatId,
                        organizacionaJedinica = o_j_temp.Naziv,
                        organizacionaJedinicaId = o_j_temp.OrganizacionaJedinica_ID
                    };

                    List<ProjekatAktivnostPlanVM> pap = db.ProjekatAktivnostPlan.Include(a => a.projekatPlan).Where(y => y.ProjekatPlan_FK == projekatId).Select(x => new ProjekatAktivnostPlanVM
                    {
                        DatumDo = x.DatumDo,
                        DatumOd = x.DatumOd,
                        JedinicaMjere = x.JedinicaMjere,
                        Kolicina = x.Kolicina,
                        Naziv = x.Naziv,
                        ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                        Sifra = x.Sifra,
                        ProjekatPlan_id = x.projekatPlan.ProjekatPlan_ID,
                        ProjekatPlan_naziv = x.projekatPlan.Naziv
                    }).ToList();

                    List<ProjekatAktivnostRealizacija> lista_par = db.ProjekatAktivnostRealizacija.ToList();
                    List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                    foreach (var x in pap)
                    {
                        foreach (var y in lista_par)
                        {
                            if (x.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK)
                            {
                                par.Add(new ProjekatAktivnostRealizacija
                                {
                                    Datum = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Datum).FirstOrDefault(),
                                    Kolicina = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Kolicina).FirstOrDefault(),
                                    Opis = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Opis).FirstOrDefault(),
                                    ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID,
                                    ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                                    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                    Korisnici_FK = y.Korisnici_FK,
                                    korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault()
                                });
                            }
                        }
                    }

                    if (pap != null)
                    {
                        int brojac = db.ProjekatAktivnostPlan.Where(s => s.ProjekatPlan_FK == projekatId).Count();

                        if (OD == null && DO == null)
                        {
                            List<RealizacijaVM> lista = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                            foreach (var x in par)
                            {
                                bool povecan = false;

                                if (lista.Count == 0)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                    lista_temp.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                                else
                                {
                                    foreach (var t in lista)
                                    {
                                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
                                        {
                                            t.odradjeno += x.Kolicina;
                                            povecan = true;
                                            break;
                                        }
                                    }
                                    if (!povecan)
                                    {
                                        lista.Add(new RealizacijaVM
                                        {
                                            aktivnostId = x.ProjekatAktivnostPlan_FK,
                                            datum = x.Datum,
                                            korisnikId = x.Korisnici_FK,
                                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                            odradjeno = x.Kolicina,
                                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                            projekatId = x.ProjekatAktivnostPlan_FK,
                                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                        });
                                    }
                                }
                            }

                            lista_realizacijaVM model = new lista_realizacijaVM
                            {
                                liste = lista,
                                organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                                projekat_Id = projekatId
                            };

                            foreach (var x in model.liste)
                            {
                                suma.ostvareno += x.odradjeno;
                                suma.planirano += x.planirano;
                                suma.procenti += (x.odradjeno / x.planirano) * 100;
                            }

                            suma.procenti /= model.liste.Count();

                            ViewData["suma"] = suma;

                            return View(model);
                        }

                        else if (OD != null && DO == null)
                        {

                            List<RealizacijaVM> lista = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                            foreach (var x in par)
                            {
                                bool povecan = false;

                                if (lista.Count == 0)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                    lista_temp.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                                else
                                {
                                    foreach (var t in lista)
                                    {
                                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
                                        {
                                            t.odradjeno += x.Kolicina;
                                            povecan = true;
                                            break;
                                        }
                                    }
                                    if (!povecan)
                                    {
                                        lista.Add(new RealizacijaVM
                                        {
                                            aktivnostId = x.ProjekatAktivnostPlan_FK,
                                            datum = x.Datum,
                                            korisnikId = x.Korisnici_FK,
                                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                            odradjeno = x.Kolicina,
                                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                            projekatId = x.ProjekatAktivnostPlan_FK,
                                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                        });
                                    }
                                }
                            }

                            foreach (var x in lista)
                            {
                                if (x.datum.Year >= OD.Value.Year && x.datum.Month >= OD.Value.Month && x.datum.Day >= OD.Value.Day)
                                {
                                    lista_final.Add(new RealizacijaVM
                                    {
                                        datum = x.datum,
                                        aktivnostId = x.aktivnostId,
                                        korisnikId = x.korisnikId,
                                        nazivProjekta = x.nazivProjekta,
                                        naziv_aktivnosti = x.naziv_aktivnosti,
                                        odradjeno = x.odradjeno,
                                        planirano = x.planirano,
                                        projekatId = x.projekatId,
                                        realizacijaId = x.realizacijaId
                                    });
                                }
                            }

                            lista_realizacijaVM model = new lista_realizacijaVM
                            {
                                liste = lista_final,
                                Od = OD.Value,
                                organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                                projekat_Id = projekatId
                            };

                            return View(model);
                        }

                        else if (DO != null && OD == null)
                        {
                            List<RealizacijaVM> lista = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                            foreach (var x in par)
                            {
                                bool povecan = false;

                                if (lista.Count == 0)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                    lista_temp.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                                else
                                {
                                    foreach (var t in lista)
                                    {
                                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
                                        {
                                            t.odradjeno += x.Kolicina;
                                            povecan = true;
                                            break;
                                        }
                                    }
                                    if (!povecan)
                                    {
                                        lista.Add(new RealizacijaVM
                                        {
                                            aktivnostId = x.ProjekatAktivnostPlan_FK,
                                            datum = x.Datum,
                                            korisnikId = x.Korisnici_FK,
                                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                            odradjeno = x.Kolicina,
                                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                            projekatId = x.ProjekatAktivnostPlan_FK,
                                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                        });
                                    }
                                }
                            }

                            foreach (var x in lista)
                            {
                                if (x.datum.Year <= DO.Value.Year && x.datum.Month <= DO.Value.Month && x.datum.Day <= DO.Value.Day)
                                {
                                    lista_final.Add(new RealizacijaVM
                                    {
                                        datum = x.datum,
                                        aktivnostId = x.aktivnostId,
                                        korisnikId = x.korisnikId,
                                        nazivProjekta = x.nazivProjekta,
                                        naziv_aktivnosti = x.naziv_aktivnosti,
                                        odradjeno = x.odradjeno,
                                        planirano = x.planirano,
                                        projekatId = x.projekatId,
                                        realizacijaId = x.realizacijaId
                                    });
                                }
                            }

                            lista_realizacijaVM model = new lista_realizacijaVM
                            {
                                liste = lista_final,
                                Do = DO.Value,
                                organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                                projekat_Id = projekatId
                            };

                            return View(model);
                        }

                        else
                        {
                            List<RealizacijaVM> lista = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                            foreach (var x in par)
                            {
                                bool povecan = false;

                                if (lista.Count == 0)
                                {
                                    lista.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                    lista_temp.Add(new RealizacijaVM
                                    {
                                        aktivnostId = x.ProjekatAktivnostPlan_FK,
                                        datum = x.Datum,
                                        korisnikId = x.Korisnici_FK,
                                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                        odradjeno = x.Kolicina,
                                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                        projekatId = x.ProjekatAktivnostPlan_FK,
                                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                    });
                                }
                                else
                                {
                                    foreach (var t in lista)
                                    {
                                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
                                        {
                                            t.odradjeno += x.Kolicina;
                                            povecan = true;
                                            break;
                                        }
                                    }
                                    if (!povecan)
                                    {
                                        lista.Add(new RealizacijaVM
                                        {
                                            aktivnostId = x.ProjekatAktivnostPlan_FK,
                                            datum = x.Datum,
                                            korisnikId = x.Korisnici_FK,
                                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                            odradjeno = x.Kolicina,
                                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                            projekatId = x.ProjekatAktivnostPlan_FK,
                                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                        });
                                    }
                                }
                            }

                            foreach (var x in lista)
                            {
                                if ((x.datum.Year <= DO.Value.Year && x.datum.Year >= OD.Value.Year) ||
                                    ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month <= DO.Value.Month && x.datum.Month >= OD.Value.Month)) ||
                                    ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month == DO.Value.Month && x.datum.Month == OD.Value.Month) && (x.datum.Day <= DO.Value.Day && x.datum.Day >= OD.Value.Day)))
                                {
                                    lista_final.Add(new RealizacijaVM
                                    {
                                        datum = x.datum,
                                        aktivnostId = x.aktivnostId,
                                        korisnikId = x.korisnikId,
                                        nazivProjekta = x.nazivProjekta,
                                        naziv_aktivnosti = x.naziv_aktivnosti,
                                        odradjeno = x.odradjeno,
                                        planirano = x.planirano,
                                        projekatId = x.projekatId,
                                        realizacijaId = x.realizacijaId
                                    });
                                }
                            }

                            lista_realizacijaVM model = new lista_realizacijaVM
                            {
                                liste = lista_final,
                                Do = DO.Value,
                                Od = OD.Value,
                                organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                                projekat_Id = projekatId
                            };

                            return View(model);
                        }
                    }
                }

                if (traziDugme == 10 && projekatId == 0 && OD == null && DO == null)
                {
                    List<ProjekatAktivnostRealizacijaVM> par = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Include(a => a.projekatAktivnostPlan.projekatPlan).Select(x => new ProjekatAktivnostRealizacijaVM
                    {
                        Datum = x.Datum,
                        Kolicina = x.Kolicina,
                        Korisnici_id = x.korisnici.Korisnici_ID,
                        Korisnici_naziv = x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString(),
                        Opis = x.Opis,
                        ProjekatAktivnostPlan_id = x.projekatAktivnostPlan.ProjekatAktivnostPlan_ID,
                        ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                        ProjekatPlan_id = x.projekatAktivnostPlan.projekatPlan.ProjekatPlan_ID,
                        ProjekatPlan_naziv = x.projekatAktivnostPlan.projekatPlan.Naziv,
                        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                        OrgJed_id = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                        OrgJed_naziv = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv
                    }).ToList();

                    List<RealizacijaVM> lista = new List<RealizacijaVM>();
                    List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
                    List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

                    foreach (var x in par)
                    {
                        bool povecan = false;

                        if (lista.Count == 0)
                        {
                            lista.Add(new RealizacijaVM
                            {
                                aktivnostId = x.ProjekatAktivnostPlan_id,
                                datum = x.Datum,
                                korisnikId = x.Korisnici_id,
                                naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                odradjeno = x.Kolicina,
                                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                projekatId = x.ProjekatPlan_id,
                                realizacijaId = x.ProjekatAktivnostRealizacija_ID
                            });
                            lista_temp.Add(new RealizacijaVM
                            {
                                aktivnostId = x.ProjekatAktivnostPlan_id,
                                datum = x.Datum,
                                korisnikId = x.Korisnici_id,
                                naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                odradjeno = x.Kolicina,
                                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                projekatId = x.ProjekatPlan_id,
                                realizacijaId = x.ProjekatAktivnostRealizacija_ID
                            });
                        }
                        else
                        {
                            foreach (var t in lista)
                            {
                                if (t.aktivnostId == x.ProjekatAktivnostPlan_id)
                                {
                                    t.odradjeno += x.Kolicina;
                                    povecan = true;
                                    break;
                                }
                            }
                            if (!povecan)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.ProjekatAktivnostPlan_id,
                                    datum = x.Datum,
                                    korisnikId = x.Korisnici_id,
                                    naziv_aktivnosti = x.ProjekatAktivnostPlan_naziv,
                                    odradjeno = x.Kolicina,
                                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_id && a.ProjekatPlan_FK == x.ProjekatPlan_id).Select(o => o.Kolicina).FirstOrDefault(),
                                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_id).Select(o => o.Naziv).FirstOrDefault(),
                                    projekatId = x.ProjekatPlan_id,
                                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
                                });
                            }
                        }
                    }

                    foreach (var x in lista)
                    {

                        lista_final.Add(new RealizacijaVM
                        {
                            datum = x.datum,
                            aktivnostId = x.aktivnostId,
                            korisnikId = x.korisnikId,
                            nazivProjekta = x.nazivProjekta,
                            naziv_aktivnosti = x.naziv_aktivnosti,
                            odradjeno = x.odradjeno,
                            planirano = x.planirano,
                            projekatId = x.projekatId,
                            realizacijaId = x.realizacijaId
                        });
                    }
                    lista_realizacijaVM model = new lista_realizacijaVM
                    {
                        liste = lista_final,
                        organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                        projekat_Id = projekatId
                    };
                    return View(model);
                }

                lista_realizacijaVM model2 = new lista_realizacijaVM()
                {
                    liste = null
                };
                return View(model2);
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<ProjekatAktivnostRealizacijaVM> lista = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacijaVM
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    Korisnici_id = x.Korisnici_FK,
                    Korisnici_naziv = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    Opis = x.Opis,
                    ProjekatAktivnostPlan_id = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                    OrgJed_id = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrgJed_naziv = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv
                }).ToList();
                ViewData["lista_relizacija"] = lista;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Unos()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<ProjekatAktivnostPlanVM> lista_proj_aktiv_plan = db.ProjekatAktivnostPlan.Include(a => a.projekatPlan).Select(x => new ProjekatAktivnostPlanVM
                {
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                    Naziv = x.Naziv,
                    ProjekatPlan_id = x.projekatPlan.ProjekatPlan_ID,
                    ProjekatPlan_naziv = x.projekatPlan.Naziv

                }).ToList();
                ViewData["lista_proj_aktiv_plan"] = lista_proj_aktiv_plan;

                List<Korisnici> lista_korisnici = db.Korisnici.Select(x => new Korisnici
                {
                    Korisnici_ID = x.Korisnici_ID,
                    Ime = x.Ime,
                    Prezime = x.Prezime
                }).ToList();
                ViewData["lista_korisnici"] = lista_korisnici;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int projekatAktivnostPlan, int korisnik, DateTime datum, float kolicina, string opis)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ProjekatAktivnostRealizacija temp = new ProjekatAktivnostRealizacija
                {
                    Datum = datum,
                    Kolicina = kolicina,
                    Korisnici_FK = korisnik,
                    Opis = opis,
                    ProjekatAktivnostPlan_FK = projekatAktivnostPlan
                };

                db.ProjekatAktivnostRealizacija.Add(temp);
                db.SaveChanges();

                List<ProjekatAktivnostRealizacijaVM> lista = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacijaVM
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    Korisnici_id = x.Korisnici_FK,
                    Korisnici_naziv = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    Opis = x.Opis,
                    ProjekatAktivnostPlan_id = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                    OrgJed_id = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrgJed_naziv = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv
                }).ToList();
                ViewData["lista_relizacija"] = lista;

                return View("Prikaz");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Ukloni(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(x => x.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.ProjekatAktivnostRealizacija.Remove(temp);
                    db.SaveChanges();
                }

                List<ProjekatAktivnostRealizacijaVM> lista = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacijaVM
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    Korisnici_id = x.Korisnici_FK,
                    Korisnici_naziv = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    Opis = x.Opis,
                    ProjekatAktivnostPlan_id = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                    OrgJed_id = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrgJed_naziv = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv
                }).ToList();
                ViewData["lista_relizacija"] = lista;

                return View("Prikaz");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Uredi(int id)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

                temp.projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == temp.ProjekatAktivnostPlan_FK).FirstOrDefault();

                ViewData["uredi"] = temp;

                return View();
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int realizacijaId, int aktivnostId, string projekat, float kolicina, DateTime datum, string opis)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == realizacijaId).FirstOrDefault();

                temp.Kolicina = kolicina;
                temp.Opis = opis;
                temp.Datum = datum;

                db.Update(temp);
                db.SaveChanges();

                List<ProjekatAktivnostRealizacijaVM> lista = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacijaVM
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    Korisnici_id = x.Korisnici_FK,
                    Korisnici_naziv = (x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString()),
                    Opis = x.Opis,
                    ProjekatAktivnostPlan_id = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                    OrgJed_id = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrgJed_naziv = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv
                }).ToList();
                ViewData["lista_relizacija"] = lista;

                return View("Prikaz");
            }
        }
    }
}