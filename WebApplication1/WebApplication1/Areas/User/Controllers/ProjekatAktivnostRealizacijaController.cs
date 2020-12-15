using System;
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
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Areas.User.Controllers
{
    public class ProjekatAktivnostRealizacijaController : Controller
    {
        private readonly ApplicationDbContext db;
        string poruka = "Morate se ponovo prijaviti";
        string poruka2 = "Nemate pravo pristupa";

        public ProjekatAktivnostRealizacijaController(ApplicationDbContext _db)
        {
            db = _db;

        }
        [Area("User")]
        public IActionResult Pdf(int o)
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

                byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

                ViewData["logo"] = logo;

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

                DataTable GetRecord(int o)
                {
                    byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

                    ViewData["logo"] = logo;

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

                DataTable dt = GetRecord(o);
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

        public lista_realizacijaVM dobaviPodatke(int uloga, int organizacijaId, int projekatId, DateTime? OD, DateTime? DO, int traziDugme = 10)
        {
            if (OD.Value.Year == 1)
                OD = null;
            if (DO.Value.Year == 1)
                DO = null;

            //List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();


            //if (projekatId == 0 && (OD != null || DO != null))
            //{
            //    List<ProjekatPlan> pp_temp_par = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

            //    List<ProjekatAktivnostPlan> pap_temp_par = db.ProjekatAktivnostPlan.ToList();
            //    List<ProjekatAktivnostPlan> pap_temp_2_par = new List<ProjekatAktivnostPlan>();

            //    foreach (var x in pap_temp_par)
            //    {
            //        foreach (var y in pp_temp)
            //        {
            //            if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
            //            {
            //                pap_temp_2_par.Add(new ProjekatAktivnostPlan
            //                {
            //                    DatumDo = x.DatumDo,
            //                    ProjekatPlan_FK = x.ProjekatPlan_FK,
            //                    DatumOd = x.DatumOd,
            //                    JedinicaMjere = x.JedinicaMjere,
            //                    Kolicina = x.Kolicina,
            //                    Naziv = x.Naziv,
            //                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
            //                    Sifra = x.Sifra,
            //                    projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
            //                });
            //            }
            //        }
            //    }

            //    List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a=>a.korisnici).Include(a=>a.projekatAktivnostPlan).Select(x=>new ProjekatAktivnostRealizacija { 
            //        Datum = x.Datum,
            //        Kolicina = x.Kolicina,
            //        korisnici = x.korisnici,
            //        Korisnici_FK = x.Korisnici_FK,
            //        Opis = x.Opis,
            //        projekatAktivnostPlan = x.projekatAktivnostPlan,
            //        ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
            //        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            //    }).ToList();
        //    List<par_final_VM> par_temp_2_par = new List<par_final_VM>();

        //    foreach (var x in par_temp)
        //    {
        //        foreach (var y in pap_temp_2_par)
        //        {
        //            if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
        //            {
        //                par_temp_2_par.Add(new par_final_VM
        //                {
        //                    Datum = x.Datum,
        //                    Kolicina = x.Kolicina,
        //                    Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
        //                    Korisnici_FK = x.Korisnici_FK,
        //                    Opis = x.Opis,
        //                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
        //                    ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
        //                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
        //                    proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
        //                    OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
        //                });
        //            }
        //        }
        //    }
        //    List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();
        //    foreach (var t in par_temp_2_par)
        //    {
        //        par.Add(new ProjekatAktivnostRealizacija
        //        {
        //            Datum = t.Datum,
        //            Kolicina = t.Kolicina,
        //            korisnici = t.Korisnici,
        //            Korisnici_FK = t.Korisnici_FK,
        //            Opis = t.Opis,
        //            projekatAktivnostPlan = t.ProjekatAktivnostPlan_all,
        //            ProjekatAktivnostPlan_FK = t.ProjekatAktivnostPlan_FK,
        //            ProjekatAktivnostRealizacija_ID = t.ProjekatAktivnostRealizacija_ID
        //        });
        //    }


        //    if (OD != null && DO != null)
        //    {

        //        List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //        List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //        foreach (var x in par)
        //        {
        //            bool povecan = false;

        //            if (lista.Count == 0)
        //            {
        //                lista.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //                lista_temp.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //            }
        //            else
        //            {
        //                foreach (var t in lista)
        //                {
        //                    if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                    {
        //                        t.odradjeno += x.Kolicina;
        //                        povecan = true;
        //                        break;
        //                    }
        //                }
        //                if (!povecan)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //            }
        //        }

        //        foreach (var x in lista)
        //        {
        //            if ((x.datum.Year <= DO.Value.Year && x.datum.Year >= OD.Value.Year) ||
        //                ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month <= DO.Value.Month && x.datum.Month >= OD.Value.Month)) ||
        //                ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month == DO.Value.Month && x.datum.Month == OD.Value.Month) && (x.datum.Day <= DO.Value.Day && x.datum.Day >= OD.Value.Day)))
        //            {
        //                lista_final.Add(new RealizacijaVM
        //                {
        //                    datum = x.datum,
        //                    aktivnostId = x.aktivnostId,
        //                    korisnikId = x.korisnikId,
        //                    nazivProjekta = x.nazivProjekta,
        //                    naziv_aktivnosti = x.naziv_aktivnosti,
        //                    odradjeno = x.odradjeno,
        //                    planirano = x.planirano,
        //                    projekatId = x.projekatId,
        //                    realizacijaId = x.realizacijaId
        //                });
        //            }
        //        }

        //        lista_realizacijaVM model = new lista_realizacijaVM
        //        {
        //            liste = lista_final,
        //            Do = DO.Value,
        //            Od = OD.Value,
        //            organizacijaId = organizacijaId,
        //            projekat_Id = projekatId
        //        };

        //        return model;
        //    }
        //    else if (DO != null)
        //    {


        //        List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //        List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //        foreach (var x in par)
        //        {
        //            bool povecan = false;

        //            if (lista.Count == 0)
        //            {
        //                lista.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //                lista_temp.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //            }
        //            else
        //            {
        //                foreach (var t in lista)
        //                {
        //                    if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                    {
        //                        t.odradjeno += x.Kolicina;
        //                        povecan = true;
        //                        break;
        //                    }
        //                }
        //                if (!povecan)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //            }
        //        }

        //        foreach (var x in lista)
        //        {
        //            if (x.datum.Year <= DO.Value.Year && x.datum.Month <= DO.Value.Month && x.datum.Day <= DO.Value.Day)
        //            {
        //                lista_final.Add(new RealizacijaVM
        //                {
        //                    datum = x.datum,
        //                    aktivnostId = x.aktivnostId,
        //                    korisnikId = x.korisnikId,
        //                    nazivProjekta = x.nazivProjekta,
        //                    naziv_aktivnosti = x.naziv_aktivnosti,
        //                    odradjeno = x.odradjeno,
        //                    planirano = x.planirano,
        //                    projekatId = x.projekatId,
        //                    realizacijaId = x.realizacijaId
        //                });
        //            }
        //        }

        //        lista_realizacijaVM model = new lista_realizacijaVM
        //        {
        //            liste = lista_final,
        //            Do = DO.Value,
        //            organizacijaId = organizacijaId,
        //            projekat_Id = projekatId
        //        };

        //        return model;
        //    }
        //    else if (OD != null)
        //    {

        //        List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //        List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //        foreach (var x in par)
        //        {
        //            bool povecan = false;

        //            if (lista.Count == 0)
        //            {
        //                lista.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //                lista_temp.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //            }
        //            else
        //            {
        //                foreach (var t in lista)
        //                {
        //                    if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                    {
        //                        t.odradjeno += x.Kolicina;
        //                        povecan = true;
        //                        break;
        //                    }
        //                }
        //                if (!povecan)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //            }
        //        }

        //        foreach (var x in lista)
        //        {
        //            if (x.datum.Year >= OD.Value.Year && x.datum.Month >= OD.Value.Month && x.datum.Day >= OD.Value.Day)
        //            {
        //                lista_final.Add(new RealizacijaVM
        //                {
        //                    datum = x.datum,
        //                    aktivnostId = x.aktivnostId,
        //                    korisnikId = x.korisnikId,
        //                    nazivProjekta = x.nazivProjekta,
        //                    naziv_aktivnosti = x.naziv_aktivnosti,
        //                    odradjeno = x.odradjeno,
        //                    planirano = x.planirano,
        //                    projekatId = x.projekatId,
        //                    realizacijaId = x.realizacijaId
        //                });
        //            }
        //        }

        //        lista_realizacijaVM model = new lista_realizacijaVM
        //        {
        //            liste = lista_final,
        //            Od = OD.Value,
        //            Do=DO.Value,
        //            organizacijaId = organizacijaId,
        //            projekat_Id = projekatId
        //        };

        //        return model;
        //    }
        //}

        //else if (projekatId == 0 && (OD != null && DO != null))
        //{
        //    List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
        //    {
        //        Datum = x.Datum,
        //        Kolicina = x.Kolicina,
        //        korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
        //        Korisnici_FK = x.Korisnici_FK,
        //        Opis = x.Opis,
        //        projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
        //        ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
        //        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
        //    }).ToList();

        //    List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //    List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //    List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //    foreach (var x in par)
        //    {
        //        bool povecan = false;

        //        if (lista.Count == 0)
        //        {
        //            lista.Add(new RealizacijaVM
        //            {
        //                aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                datum = x.Datum,
        //                korisnikId = x.Korisnici_FK,
        //                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                odradjeno = x.Kolicina,
        //                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                projekatId = x.ProjekatAktivnostPlan_FK,
        //                realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //            });
        //            lista_temp.Add(new RealizacijaVM
        //            {
        //                aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                datum = x.Datum,
        //                korisnikId = x.Korisnici_FK,
        //                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                odradjeno = x.Kolicina,
        //                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                projekatId = x.ProjekatAktivnostPlan_FK,
        //                realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //            });
        //        }
        //        else
        //        {
        //            foreach (var t in lista)
        //            {
        //                if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                {
        //                    t.odradjeno += x.Kolicina;
        //                    povecan = true;
        //                    break;
        //                }
        //            }
        //            if (!povecan)
        //            {
        //                lista.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //            }
        //        }
        //    }

        //    foreach (var x in lista)
        //    {

        //        lista_final.Add(new RealizacijaVM
        //        {
        //            datum = x.datum,
        //            aktivnostId = x.aktivnostId,
        //            korisnikId = x.korisnikId,
        //            nazivProjekta = x.nazivProjekta,
        //            naziv_aktivnosti = x.naziv_aktivnosti,
        //            odradjeno = x.odradjeno,
        //            planirano = x.planirano,
        //            projekatId = x.projekatId,
        //            realizacijaId = x.realizacijaId
        //        });

        //    }

        //    lista_realizacijaVM model = new lista_realizacijaVM
        //    {
        //        liste = lista_final,
        //        Do = DO.Value,
        //        Od = OD.Value,
        //        organizacijaId = organizacijaId,
        //        projekat_Id = projekatId
        //    };

        //    ViewData["lista_projekata"] = lista;
        //    return model;
        //}

        //else if (projekatId >= 1)
        //{
        //    ProjekatPlan p_temp = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == projekatId).FirstOrDefault();
        //    OrganizacionaJedinica o_j_temp = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == p_temp.OrganizacionaJedinica_FK).FirstOrDefault();

        //    RealizacijaDetaljiSuma suma = new RealizacijaDetaljiSuma
        //    {
        //        naziv_projekta = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == projekatId).Select(o => o.Naziv).FirstOrDefault(),
        //        ostvareno = 0,
        //        planirano = 0,
        //        procenti = 0,
        //        ProjekatId = projekatId,
        //        organizacionaJedinica = o_j_temp.Naziv,
        //        organizacionaJedinicaId = o_j_temp.OrganizacionaJedinica_ID
        //    };

        //    List<ProjekatAktivnostPlan> pap = db.ProjekatAktivnostPlan.Where(y => y.ProjekatPlan_FK == projekatId).Select(x => new ProjekatAktivnostPlan
        //    {
        //        DatumDo = x.DatumDo,
        //        DatumOd = x.DatumOd,
        //        JedinicaMjere = x.JedinicaMjere,
        //        Kolicina = x.Kolicina,
        //        Naziv = x.Naziv,
        //        ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
        //        projekatPlan = db.ProjekatPlan.Where(v => v.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
        //        ProjekatPlan_FK = x.ProjekatPlan_FK,
        //        Sifra = x.Sifra
        //    }).ToList();

        //    List<ProjekatAktivnostRealizacija> lista_par = db.ProjekatAktivnostRealizacija.ToList();
        //    List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

        //    foreach (var x in pap)
        //    {
        //        foreach (var y in lista_par)
        //        {
        //            if (x.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK)
        //            {
        //                par.Add(new ProjekatAktivnostRealizacija
        //                {
        //                    Datum = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Datum).FirstOrDefault(),
        //                    Kolicina = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Kolicina).FirstOrDefault(),
        //                    Opis = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Opis).FirstOrDefault(),
        //                    ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID,
        //                    ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
        //                    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
        //                    Korisnici_FK = y.Korisnici_FK,
        //                    korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault()
        //                });
        //            }
        //        }
        //    }

        //    if (pap != null)
        //    {
        //        int brojac = db.ProjekatAktivnostPlan.Where(s => s.ProjekatPlan_FK == projekatId).Count();

        //        if (OD == null && DO == null)
        //        {
        //            List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //            foreach (var x in par)
        //            {
        //                bool povecan = false;

        //                if (lista.Count == 0)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                    lista_temp.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //                else
        //                {
        //                    foreach (var t in lista)
        //                    {
        //                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                        {
        //                            t.odradjeno += x.Kolicina;
        //                            povecan = true;
        //                            break;
        //                        }
        //                    }
        //                    if (!povecan)
        //                    {
        //                        lista.Add(new RealizacijaVM
        //                        {
        //                            aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                            datum = x.Datum,
        //                            korisnikId = x.Korisnici_FK,
        //                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                            odradjeno = x.Kolicina,
        //                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                            projekatId = x.ProjekatAktivnostPlan_FK,
        //                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                        });
        //                    }
        //                }
        //            }

        //            lista_realizacijaVM model = new lista_realizacijaVM
        //            {
        //                liste = lista,
        //                organizacijaId = organizacijaId,
        //                projekat_Id = projekatId
        //            };

        //            foreach (var x in model.liste)
        //            {
        //                suma.ostvareno += x.odradjeno;
        //                suma.planirano += x.planirano;
        //                suma.procenti += (x.odradjeno / x.planirano) * 100;
        //            }

        //            suma.procenti /= model.liste.Count();

        //            ViewData["suma"] = suma;

        //            return model;
        //        }

        //        else if (OD != null && DO == null)
        //        {

        //            List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //            foreach (var x in par)
        //            {
        //                bool povecan = false;

        //                if (lista.Count == 0)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                    lista_temp.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //                else
        //                {
        //                    foreach (var t in lista)
        //                    {
        //                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                        {
        //                            t.odradjeno += x.Kolicina;
        //                            povecan = true;
        //                            break;
        //                        }
        //                    }
        //                    if (!povecan)
        //                    {
        //                        lista.Add(new RealizacijaVM
        //                        {
        //                            aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                            datum = x.Datum,
        //                            korisnikId = x.Korisnici_FK,
        //                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                            odradjeno = x.Kolicina,
        //                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                            projekatId = x.ProjekatAktivnostPlan_FK,
        //                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                        });
        //                    }
        //                }
        //            }

        //            foreach (var x in lista)
        //            {
        //                if (x.datum.Year >= OD.Value.Year && x.datum.Month >= OD.Value.Month && x.datum.Day >= OD.Value.Day)
        //                {
        //                    lista_final.Add(new RealizacijaVM
        //                    {
        //                        datum = x.datum,
        //                        aktivnostId = x.aktivnostId,
        //                        korisnikId = x.korisnikId,
        //                        nazivProjekta = x.nazivProjekta,
        //                        naziv_aktivnosti = x.naziv_aktivnosti,
        //                        odradjeno = x.odradjeno,
        //                        planirano = x.planirano,
        //                        projekatId = x.projekatId,
        //                        realizacijaId = x.realizacijaId
        //                    });
        //                }
        //            }

        //            lista_realizacijaVM model = new lista_realizacijaVM
        //            {
        //                liste = lista_final,
        //                Od = OD.Value,
        //                organizacijaId = organizacijaId,
        //                projekat_Id = projekatId
        //            };

        //            return model;
        //        }

        //        else if (DO != null && OD == null)
        //        {
        //            List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //            foreach (var x in par)
        //            {
        //                bool povecan = false;

        //                if (lista.Count == 0)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                    lista_temp.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //                else
        //                {
        //                    foreach (var t in lista)
        //                    {
        //                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                        {
        //                            t.odradjeno += x.Kolicina;
        //                            povecan = true;
        //                            break;
        //                        }
        //                    }
        //                    if (!povecan)
        //                    {
        //                        lista.Add(new RealizacijaVM
        //                        {
        //                            aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                            datum = x.Datum,
        //                            korisnikId = x.Korisnici_FK,
        //                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                            odradjeno = x.Kolicina,
        //                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                            projekatId = x.ProjekatAktivnostPlan_FK,
        //                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                        });
        //                    }
        //                }
        //            }

        //            foreach (var x in lista)
        //            {
        //                if (x.datum.Year <= DO.Value.Year && x.datum.Month <= DO.Value.Month && x.datum.Day <= DO.Value.Day)
        //                {
        //                    lista_final.Add(new RealizacijaVM
        //                    {
        //                        datum = x.datum,
        //                        aktivnostId = x.aktivnostId,
        //                        korisnikId = x.korisnikId,
        //                        nazivProjekta = x.nazivProjekta,
        //                        naziv_aktivnosti = x.naziv_aktivnosti,
        //                        odradjeno = x.odradjeno,
        //                        planirano = x.planirano,
        //                        projekatId = x.projekatId,
        //                        realizacijaId = x.realizacijaId
        //                    });
        //                }
        //            }

        //            lista_realizacijaVM model = new lista_realizacijaVM
        //            {
        //                liste = lista_final,
        //                Do = DO.Value,
        //                organizacijaId = organizacijaId,
        //                projekat_Id = projekatId
        //            };

        //            return model;
        //        }

        //        else
        //        {
        //            List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //            List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //            foreach (var x in par)
        //            {
        //                bool povecan = false;

        //                if (lista.Count == 0)
        //                {
        //                    lista.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                    lista_temp.Add(new RealizacijaVM
        //                    {
        //                        aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                        datum = x.Datum,
        //                        korisnikId = x.Korisnici_FK,
        //                        naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                        odradjeno = x.Kolicina,
        //                        planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                        nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                        projekatId = x.ProjekatAktivnostPlan_FK,
        //                        realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                    });
        //                }
        //                else
        //                {
        //                    foreach (var t in lista)
        //                    {
        //                        if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                        {
        //                            t.odradjeno += x.Kolicina;
        //                            povecan = true;
        //                            break;
        //                        }
        //                    }
        //                    if (!povecan)
        //                    {
        //                        lista.Add(new RealizacijaVM
        //                        {
        //                            aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                            datum = x.Datum,
        //                            korisnikId = x.Korisnici_FK,
        //                            naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                            odradjeno = x.Kolicina,
        //                            planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                            nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                            projekatId = x.ProjekatAktivnostPlan_FK,
        //                            realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                        });
        //                    }
        //                }
        //            }

        //            foreach (var x in lista)
        //            {
        //                if ((x.datum.Year <= DO.Value.Year && x.datum.Year >= OD.Value.Year) ||
        //                    ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month <= DO.Value.Month && x.datum.Month >= OD.Value.Month)) ||
        //                    ((x.datum.Year == DO.Value.Year && x.datum.Year == OD.Value.Year) && (x.datum.Month == DO.Value.Month && x.datum.Month == OD.Value.Month) && (x.datum.Day <= DO.Value.Day && x.datum.Day >= OD.Value.Day)))
        //                {
        //                    lista_final.Add(new RealizacijaVM
        //                    {
        //                        datum = x.datum,
        //                        aktivnostId = x.aktivnostId,
        //                        korisnikId = x.korisnikId,
        //                        nazivProjekta = x.nazivProjekta,
        //                        naziv_aktivnosti = x.naziv_aktivnosti,
        //                        odradjeno = x.odradjeno,
        //                        planirano = x.planirano,
        //                        projekatId = x.projekatId,
        //                        realizacijaId = x.realizacijaId
        //                    });
        //                }
        //            }

        //            lista_realizacijaVM model = new lista_realizacijaVM
        //            {
        //                liste = lista_final,
        //                Do = DO.Value,
        //                Od = OD.Value,
        //                organizacijaId = organizacijaId,
        //                projekat_Id = projekatId
        //            };

        //            return model;
        //        }
        //    }
        //}

        //if (traziDugme == 10 && projekatId == 0 && OD == null && DO == null)
        //{
        //    //List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
        //    //{
        //    //    Datum = x.Datum,
        //    //    Kolicina = x.Kolicina,
        //    //    korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
        //    //    Korisnici_FK = x.Korisnici_FK,
        //    //    Opis = x.Opis,
        //    //    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
        //    //    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
        //    //    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
        //    //}).ToList();


        //    List<ProjekatPlan> pp_temp_par = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

        //    List<ProjekatAktivnostPlan> pap_temp_par = db.ProjekatAktivnostPlan.ToList();
        //    List<ProjekatAktivnostPlan> pap_temp_2_par = new List<ProjekatAktivnostPlan>();

        //    foreach (var x in pap_temp_par)
        //    {
        //        foreach (var y in pp_temp)
        //        {
        //            if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
        //            {
        //                pap_temp_2_par.Add(new ProjekatAktivnostPlan
        //                {
        //                    DatumDo = x.DatumDo,
        //                    ProjekatPlan_FK = x.ProjekatPlan_FK,
        //                    DatumOd = x.DatumOd,
        //                    JedinicaMjere = x.JedinicaMjere,
        //                    Kolicina = x.Kolicina,
        //                    Naziv = x.Naziv,
        //                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
        //                    Sifra = x.Sifra,
        //                    projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
        //                });
        //            }
        //        }
        //    }

        //    List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a=>a.korisnici).Include(a=>a.projekatAktivnostPlan).Select(x=>new ProjekatAktivnostRealizacija { 
        //        Datum = x.Datum,
        //        Kolicina = x.Kolicina,
        //        korisnici = x.korisnici,
        //        Korisnici_FK = x.Korisnici_FK,
        //        Opis = x.Opis,
        //        projekatAktivnostPlan = x.projekatAktivnostPlan,
        //        ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
        //        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
        //    }).ToList();
        //    List<par_final_VM> par_temp_2_par = new List<par_final_VM>();

        //    foreach (var x in par_temp)
        //    {
        //        foreach (var y in pap_temp_2_par)
        //        {
        //            if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
        //            {
        //                par_temp_2_par.Add(new par_final_VM
        //                {
        //                    Datum = x.Datum,
        //                    Kolicina = x.Kolicina,
        //                    Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
        //                    Korisnici_FK = x.Korisnici_FK,
        //                    Opis = x.Opis,
        //                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
        //                    ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
        //                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
        //                    proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
        //                    OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
        //                });
        //            }
        //        }
        //    }
        //    List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();
        //    foreach (var t in par_temp_2_par)
        //    {
        //        par.Add(new ProjekatAktivnostRealizacija
        //        {
        //            Datum = t.Datum,
        //            Kolicina = t.Kolicina,
        //            korisnici = t.Korisnici,
        //            Korisnici_FK = t.Korisnici_FK,
        //            Opis = t.Opis,
        //            projekatAktivnostPlan = t.ProjekatAktivnostPlan_all,
        //            ProjekatAktivnostPlan_FK = t.ProjekatAktivnostPlan_FK,
        //            ProjekatAktivnostRealizacija_ID = t.ProjekatAktivnostRealizacija_ID
        //        });
        //    }

        //    List<RealizacijaVM> lista = new List<RealizacijaVM>();
        //    List<RealizacijaVM> lista_final = new List<RealizacijaVM>();
        //    List<RealizacijaVM> lista_temp = new List<RealizacijaVM>();

        //    foreach (var x in par)
        //    {
        //        bool povecan = false;

        //        if (lista.Count == 0)
        //        {
        //            lista.Add(new RealizacijaVM
        //            {
        //                aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                datum = x.Datum,
        //                korisnikId = x.Korisnici_FK,
        //                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                odradjeno = x.Kolicina,
        //                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                projekatId = x.ProjekatAktivnostPlan_FK,
        //                realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //            });
        //            lista_temp.Add(new RealizacijaVM
        //            {
        //                aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                datum = x.Datum,
        //                korisnikId = x.Korisnici_FK,
        //                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                odradjeno = x.Kolicina,
        //                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                projekatId = x.ProjekatAktivnostPlan_FK,
        //                realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //            });
        //        }
        //        else
        //        {
        //            foreach (var t in lista)
        //            {
        //                if (t.aktivnostId == x.ProjekatAktivnostPlan_FK)
        //                {
        //                    t.odradjeno += x.Kolicina;
        //                    povecan = true;
        //                    break;
        //                }
        //            }
        //            if (!povecan)
        //            {
        //                lista.Add(new RealizacijaVM
        //                {
        //                    aktivnostId = x.ProjekatAktivnostPlan_FK,
        //                    datum = x.Datum,
        //                    korisnikId = x.Korisnici_FK,
        //                    naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
        //                    odradjeno = x.Kolicina,
        //                    planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
        //                    nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
        //                    projekatId = x.ProjekatAktivnostPlan_FK,
        //                    realizacijaId = x.ProjekatAktivnostRealizacija_ID
        //                });
        //            }
        //        }
        //    }

        //    foreach (var x in lista)
        //    {

        //        lista_final.Add(new RealizacijaVM
        //        {
        //            datum = x.datum,
        //            aktivnostId = x.aktivnostId,
        //            korisnikId = x.korisnikId,
        //            nazivProjekta = x.nazivProjekta,
        //            naziv_aktivnosti = x.naziv_aktivnosti,
        //            odradjeno = x.odradjeno,
        //            planirano = x.planirano,
        //            projekatId = x.projekatId,
        //            realizacijaId = x.realizacijaId
        //        });
        //    }

        //    lista_realizacijaVM model = new lista_realizacijaVM
        //    {
        //        liste = lista_final,
        //        organizacijaId = organizacijaId,
        //        projekat_Id = projekatId
        //    };

        //    return model;
        //}

        //lista_realizacijaVM model2 = new lista_realizacijaVM()
        //{
        //    liste = null
        //};
        //return model2;


        byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;


            List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

            ViewData["projekti"] = pp_temp;

            if (projekatId == 0 && (OD != null || DO != null))
            {

                List<ProjekatPlan> pp_temp_par = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                List<ProjekatAktivnostPlan> pap_temp_par = db.ProjekatAktivnostPlan.ToList();
                List<ProjekatAktivnostPlan> pap_temp_2_par = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp_par)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2_par.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    korisnici = x.korisnici,
                    Korisnici_FK = x.Korisnici_FK,
                    Opis = x.Opis,
                    projekatAktivnostPlan = x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2_par = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2_par)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2_par.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();
                foreach (var t in par_temp_2_par)
                {
                    par.Add(new ProjekatAktivnostRealizacija
                    {
                        Datum = t.Datum,
                        Kolicina = t.Kolicina,
                        korisnici = t.Korisnici,
                        Korisnici_FK = t.Korisnici_FK,
                        Opis = t.Opis,
                        projekatAktivnostPlan = t.ProjekatAktivnostPlan_all,
                        ProjekatAktivnostPlan_FK = t.ProjekatAktivnostPlan_FK,
                        ProjekatAktivnostRealizacija_ID = t.ProjekatAktivnostRealizacija_ID
                    });
                }


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

                    return model;
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

                    return model;
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

                    return model;
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
                return model;
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

                List<ProjekatAktivnostPlan> pap = db.ProjekatAktivnostPlan.Where(y => y.ProjekatPlan_FK == projekatId).Include(a => a.projekatPlan).Select(x => new ProjekatAktivnostPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    JedinicaMjere = x.JedinicaMjere,
                    Kolicina = x.Kolicina,
                    Naziv = x.Naziv,
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                    projekatPlan = x.projekatPlan,
                    ProjekatPlan_FK = x.ProjekatPlan_FK,
                    Sifra = x.Sifra
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

                        return model;
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

                        return model;
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

                        return model;
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

                        return model;
                    }
                }
            }

            if (traziDugme == 10 && projekatId == 0 && OD == null && DO == null)
            {

                List<ProjekatPlan> pp_temp_par = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                List<ProjekatAktivnostPlan> pap_temp_par = db.ProjekatAktivnostPlan.ToList();
                List<ProjekatAktivnostPlan> pap_temp_2_par = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp_par)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2_par.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    korisnici = x.korisnici,
                    Korisnici_FK = x.Korisnici_FK,
                    Opis = x.Opis,
                    projekatAktivnostPlan = x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2_par = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2_par)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2_par.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();
                foreach (var t in par_temp_2_par)
                {
                    par.Add(new ProjekatAktivnostRealizacija
                    {
                        Datum = t.Datum,
                        Kolicina = t.Kolicina,
                        korisnici = t.Korisnici,
                        Korisnici_FK = t.Korisnici_FK,
                        Opis = t.Opis,
                        projekatAktivnostPlan = t.ProjekatAktivnostPlan_all,
                        ProjekatAktivnostPlan_FK = t.ProjekatAktivnostPlan_FK,
                        ProjekatAktivnostRealizacija_ID = t.ProjekatAktivnostRealizacija_ID
                    });
                }

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
                    organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                    projekat_Id = projekatId,

                };

                return model;
            }

            lista_realizacijaVM model2 = new lista_realizacijaVM()
            {
                liste = null
            };
            return model2;
        }
        [Area("User")]
        public IActionResult Excel2(int uloga,int u, int organizacijaId, int projekatId, DateTime datumOD, DateTime datumDO)
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
                lista_realizacijaVM m_final = dobaviPodatke(uloga, organizacijaId, projekatId, datumOD, datumDO);

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Realizacija");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Projekat Plan";
                    worksheet.Cell(currentRow, 2).Value = "Projekat Aktivnost Plan";
                    worksheet.Cell(currentRow, 3).Value = "Datum";
                    worksheet.Cell(currentRow, 4).Value = "Planirano";
                    worksheet.Cell(currentRow, 5).Value = "Ostvareno";
                    worksheet.Cell(currentRow, 6).Value = "Precntualno";

                    foreach (var x in m_final.liste)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.nazivProjekta.ToString();
                        worksheet.Cell(currentRow, 2).Value = x.naziv_aktivnosti.ToString();
                        worksheet.Cell(currentRow, 3).Value = x.datum.Date.Day + "." + x.datum.Date.Month + "." + x.datum.Date.Year + ".";
                        worksheet.Cell(currentRow, 4).Value = x.planirano;
                        worksheet.Cell(currentRow, 5).Value = x.odradjeno;
                        worksheet.Cell(currentRow, 6).Value = Math.Round((x.odradjeno / x.planirano) * 100);
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
                List<ProjekatAktivnostPlan> pap_temp_2 = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    korisnici = x.korisnici,
                    Korisnici_FK = x.Korisnici_FK,
                    Opis = x.Opis,
                    projekatAktivnostPlan = x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2 = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Realizacija");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "Projekat Plan";
                    worksheet.Cell(currentRow, 2).Value = "Projekat Aktivnost Plan";
                    worksheet.Cell(currentRow, 3).Value = "Korisnik";
                    worksheet.Cell(currentRow, 4).Value = "Datum";
                    worksheet.Cell(currentRow, 5).Value = "Količina";
                    worksheet.Cell(currentRow, 6).Value = "Opis";

                    foreach (var x in par_temp_2)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = x.proj_plan.Naziv.ToString();
                        worksheet.Cell(currentRow, 2).Value = x.ProjekatAktivnostPlan_all.Naziv.ToString();
                        worksheet.Cell(currentRow, 3).Value = x.Korisnici.Ime.ToString() + " " + x.Korisnici.Prezime.ToString();
                        worksheet.Cell(currentRow, 4).Value = x.Datum.Date.Day + "." + x.Datum.Date.Month + "." + x.Datum.Date.Year + ".";
                        worksheet.Cell(currentRow, 5).Value = x.Kolicina;
                        worksheet.Cell(currentRow, 6).Value = x.Opis;
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
        [Area("User")]
        public IActionResult PrintPreview()
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
                byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ViewData["logo"] = logo;
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

        [Area("User")]
        public IActionResult Detalji(int projekatId = 0, DateTime? datOD = null, DateTime? datDO = null, int traziDugme = 0)
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
                byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ViewData["logo"] = logo;


                List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                ViewData["projekti"] = pp_temp;

                if (projekatId == 0 && (datOD != null || datDO != null))
                {

                    List<ProjekatPlan> pp_temp_par = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                    List<ProjekatAktivnostPlan> pap_temp_par = db.ProjekatAktivnostPlan.ToList();
                    List<ProjekatAktivnostPlan> pap_temp_2_par = new List<ProjekatAktivnostPlan>();

                    foreach (var x in pap_temp_par)
                    {
                        foreach (var y in pp_temp)
                        {
                            if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                            {
                                pap_temp_2_par.Add(new ProjekatAktivnostPlan
                                {
                                    DatumDo = x.DatumDo,
                                    ProjekatPlan_FK = x.ProjekatPlan_FK,
                                    DatumOd = x.DatumOd,
                                    JedinicaMjere = x.JedinicaMjere,
                                    Kolicina = x.Kolicina,
                                    Naziv = x.Naziv,
                                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                    Sifra = x.Sifra,
                                    projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                                });
                            }
                        }
                    }

                    List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                    {
                        Datum = x.Datum,
                        Kolicina = x.Kolicina,
                        korisnici = x.korisnici,
                        Korisnici_FK = x.Korisnici_FK,
                        Opis = x.Opis,
                        projekatAktivnostPlan = x.projekatAktivnostPlan,
                        ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                    }).ToList();
                    List<par_final_VM> par_temp_2_par = new List<par_final_VM>();

                    foreach (var x in par_temp)
                    {
                        foreach (var y in pap_temp_2_par)
                        {
                            if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                            {
                                par_temp_2_par.Add(new par_final_VM
                                {
                                    Datum = x.Datum,
                                    Kolicina = x.Kolicina,
                                    Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                    Korisnici_FK = x.Korisnici_FK,
                                    Opis = x.Opis,
                                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                    ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                    proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                    OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                                });
                            }
                        }
                    }
                    List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();
                    foreach (var t in par_temp_2_par)
                    {
                        par.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = t.Datum,
                            Kolicina = t.Kolicina,
                            korisnici = t.Korisnici,
                            Korisnici_FK = t.Korisnici_FK,
                            Opis = t.Opis,
                            projekatAktivnostPlan = t.ProjekatAktivnostPlan_all,
                            ProjekatAktivnostPlan_FK = t.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID = t.ProjekatAktivnostRealizacija_ID
                        });
                    }


                    if (datOD != null && datDO != null)
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
                            if ((x.datum.Year <= datDO.Value.Year && x.datum.Year >= datOD.Value.Year) ||
                                ((x.datum.Year == datDO.Value.Year && x.datum.Year == datOD.Value.Year) && (x.datum.Month <= datDO.Value.Month && x.datum.Month >= datOD.Value.Month)) ||
                                ((x.datum.Year == datDO.Value.Year && x.datum.Year == datOD.Value.Year) && (x.datum.Month == datDO.Value.Month && x.datum.Month == datOD.Value.Month) && (x.datum.Day <= datDO.Value.Day && x.datum.Day >= datOD.Value.Day)))
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
                            Do = datDO.Value,
                            Od = datOD.Value,
                            organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                            projekat_Id = projekatId
                        };

                        return View(model);
                    }
                    else if (datDO != null)
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
                            if (x.datum.Year <= datDO.Value.Year && x.datum.Month <= datDO.Value.Month && x.datum.Day <= datDO.Value.Day)
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
                            Do = datDO.Value,
                            organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                            projekat_Id = projekatId
                        };

                        return View(model);
                    }
                    else if (datOD != null)
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
                            if (x.datum.Year >= datOD.Value.Year && x.datum.Month >= datOD.Value.Month && x.datum.Day >= datOD.Value.Day)
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
                            Od = datOD.Value,
                            organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                            projekat_Id = projekatId
                        };

                        return View(model);
                    }
                }

                else if (projekatId == 0 && (datOD != null && datDO != null))
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
                        Do = datDO.Value,
                        Od = datOD.Value,
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

                    List<ProjekatAktivnostPlan> pap = db.ProjekatAktivnostPlan.Where(y => y.ProjekatPlan_FK == projekatId).Include(a=>a.projekatPlan).Select(x => new ProjekatAktivnostPlan
                    {
                        DatumDo = x.DatumDo,
                        DatumOd = x.DatumOd,
                        JedinicaMjere = x.JedinicaMjere,
                        Kolicina = x.Kolicina,
                        Naziv = x.Naziv,
                        ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                        projekatPlan = x.projekatPlan,
                        ProjekatPlan_FK = x.ProjekatPlan_FK,
                        Sifra = x.Sifra
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

                        if (datOD == null && datDO == null)
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

                        else if (datOD != null && datDO == null)
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
                                if (x.datum.Year >= datOD.Value.Year && x.datum.Month >= datOD.Value.Month && x.datum.Day >= datOD.Value.Day)
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
                                Od = datOD.Value,
                                organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                                projekat_Id = projekatId
                            };

                            return View(model);
                        }

                        else if (datDO != null && datOD == null)
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
                                if (x.datum.Year <= datDO.Value.Year && x.datum.Month <= datDO.Value.Month && x.datum.Day <= datDO.Value.Day)
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
                                Do = datDO.Value,
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
                                if ((x.datum.Year <= datDO.Value.Year && x.datum.Year >= datOD.Value.Year) ||
                                    ((x.datum.Year == datDO.Value.Year && x.datum.Year == datOD.Value.Year) && (x.datum.Month <= datDO.Value.Month && x.datum.Month >= datOD.Value.Month)) ||
                                    ((x.datum.Year == datDO.Value.Year && x.datum.Year == datOD.Value.Year) && (x.datum.Month == datDO.Value.Month && x.datum.Month == datOD.Value.Month) && (x.datum.Day <= datDO.Value.Day && x.datum.Day >= datOD.Value.Day)))
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
                                Do = datDO.Value,
                                Od = datOD.Value,
                                organizacijaId = (int)HttpContext.Session.GetInt32("organisation ID"),
                                projekat_Id = projekatId
                            };

                            return View(model);
                        }
                    }
                }

                if (traziDugme == 10 && projekatId == 0 && datOD == null && datDO == null)
                {

                    List<ProjekatPlan> pp_temp_par = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                    List<ProjekatAktivnostPlan> pap_temp_par = db.ProjekatAktivnostPlan.ToList();
                    List<ProjekatAktivnostPlan> pap_temp_2_par = new List<ProjekatAktivnostPlan>();

                    foreach (var x in pap_temp_par)
                    {
                        foreach (var y in pp_temp)
                        {
                            if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                            {
                                pap_temp_2_par.Add(new ProjekatAktivnostPlan
                                {
                                    DatumDo = x.DatumDo,
                                    ProjekatPlan_FK = x.ProjekatPlan_FK,
                                    DatumOd = x.DatumOd,
                                    JedinicaMjere = x.JedinicaMjere,
                                    Kolicina = x.Kolicina,
                                    Naziv = x.Naziv,
                                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                    Sifra = x.Sifra,
                                    projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                                });
                            }
                        }
                    }

                    List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                    {
                        Datum = x.Datum,
                        Kolicina = x.Kolicina,
                        korisnici = x.korisnici,
                        Korisnici_FK = x.Korisnici_FK,
                        Opis = x.Opis,
                        projekatAktivnostPlan = x.projekatAktivnostPlan,
                        ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                        ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                    }).ToList();
                    List<par_final_VM> par_temp_2_par = new List<par_final_VM>();

                    foreach (var x in par_temp)
                    {
                        foreach (var y in pap_temp_2_par)
                        {
                            if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                            {
                                par_temp_2_par.Add(new par_final_VM
                                {
                                    Datum = x.Datum,
                                    Kolicina = x.Kolicina,
                                    Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                    Korisnici_FK = x.Korisnici_FK,
                                    Opis = x.Opis,
                                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                    ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                    proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                    OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                                });
                            }
                        }
                    }
                    List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();
                    foreach (var t in par_temp_2_par)
                    {
                        par.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = t.Datum,
                            Kolicina = t.Kolicina,
                            korisnici = t.Korisnici,
                            Korisnici_FK = t.Korisnici_FK,
                            Opis = t.Opis,
                            projekatAktivnostPlan = t.ProjekatAktivnostPlan_all,
                            ProjekatAktivnostPlan_FK = t.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID = t.ProjekatAktivnostRealizacija_ID
                        });
                    }

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
                byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

                ViewData["logo"] = logo;


                List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
                List<ProjekatAktivnostPlan> pap_temp_2 = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    korisnici = x.korisnici,
                    Korisnici_FK = x.Korisnici_FK,
                    Opis = x.Opis,
                    projekatAktivnostPlan = x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2 = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }

                ViewData["lista_relizacija"] = par_temp_2;

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

                List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
                List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
                List<dropdownAdminOrgUnosRealVM> pap_final = new List<dropdownAdminOrgUnosRealVM>();

                foreach (var x in pap_temp)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_final.Add(new dropdownAdminOrgUnosRealVM
                            {
                                aktivnostId = x.ProjekatAktivnostPlan_ID,
                                aktivnost = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_ID).Select(o => o.Naziv).FirstOrDefault(),
                                projekat = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault()
                            });
                        }
                    }
                }

                ViewData["lista_proj_aktiv_plan"] = pap_final;

                List<Korisnici_OrganizacionaJedinica> ko_temp = db.Korisnici_OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();
                List<Korisnici> korisnici_temp = db.Korisnici.ToList();
                List<Korisnici> korisnici_final = new List<Korisnici>();

                foreach (var x in korisnici_temp)
                {
                    foreach (var y in ko_temp)
                    {
                        if (x.Korisnici_ID == y.Korisnici_FK)
                        {
                            korisnici_final.Add(new Korisnici
                            {
                                Korisnici_ID = x.Korisnici_ID,
                                Ime = x.Ime,
                                Prezime = x.Prezime
                            });
                        }
                    }
                }

                ViewData["lista_korisnici"] = korisnici_final;

                return View();
            }
        }
        [Area("User")]
        public IActionResult UnosSnimi(int projekatAktivnostPlan, int korisnik, DateTime datum, float kolicina, string opis)
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

                List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
                List<ProjekatAktivnostPlan> pap_temp_2 = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    korisnici = x.korisnici,
                    Korisnici_FK = x.Korisnici_FK,
                    Opis = x.Opis,
                    projekatAktivnostPlan = x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2 = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }

                ViewData["lista_relizacija"] = par_temp_2;

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

                ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(x => x.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

                if (temp != null)
                {
                    db.ProjekatAktivnostRealizacija.Remove(temp);
                    db.SaveChanges();
                }

                List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
                List<ProjekatAktivnostPlan> pap_temp_2 = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    korisnici = x.korisnici,
                    Korisnici_FK = x.Korisnici_FK,
                    Opis = x.Opis,
                    projekatAktivnostPlan = x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2 = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }

                ViewData["lista_relizacija"] = par_temp_2;

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

                ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

                temp.projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == temp.ProjekatAktivnostPlan_FK).FirstOrDefault();

                ViewData["uredi"] = temp;

                return View();
            }
        }
        [Area("User")]
        public IActionResult UrediSnimi(int realizacijaId, int aktivnostId, string projekat, float kolicina, DateTime datum, string opis)
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

                ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == realizacijaId).FirstOrDefault();

                temp.Kolicina = kolicina;
                temp.Opis = opis;
                temp.Datum = datum;

                db.Update(temp);
                db.SaveChanges();

                List<ProjekatPlan> pp_temp = db.ProjekatPlan.Where(a => a.OrganizacionaJedinica_FK == (int)HttpContext.Session.GetInt32("orgJed ID")).ToList();

                List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
                List<ProjekatAktivnostPlan> pap_temp_2 = new List<ProjekatAktivnostPlan>();

                foreach (var x in pap_temp)
                {
                    foreach (var y in pp_temp)
                    {
                        if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                        {
                            pap_temp_2.Add(new ProjekatAktivnostPlan
                            {
                                DatumDo = x.DatumDo,
                                ProjekatPlan_FK = x.ProjekatPlan_FK,
                                DatumOd = x.DatumOd,
                                JedinicaMjere = x.JedinicaMjere,
                                Kolicina = x.Kolicina,
                                Naziv = x.Naziv,
                                ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                                Sifra = x.Sifra,
                                projekatPlan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault()
                            });
                        }
                    }
                }

                List<ProjekatAktivnostRealizacija> par_temp = db.ProjekatAktivnostRealizacija.Include(a=>a.korisnici).Include(a=>a.projekatAktivnostPlan).Select(x=>new ProjekatAktivnostRealizacija { 
                    Datum=x.Datum,
                    Kolicina=x.Kolicina,
                    korisnici=x.korisnici,
                    Korisnici_FK=x.Korisnici_FK,
                    Opis=x.Opis,
                    projekatAktivnostPlan=x.projekatAktivnostPlan,
                    ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID
                }).ToList();
                List<par_final_VM> par_temp_2 = new List<par_final_VM>();

                foreach (var x in par_temp)
                {
                    foreach (var y in pap_temp_2)
                    {
                        if (x.ProjekatAktivnostPlan_FK == y.ProjekatAktivnostPlan_ID)
                        {
                            par_temp_2.Add(new par_final_VM
                            {
                                Datum = x.Datum,
                                Kolicina = x.Kolicina,
                                Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                                Korisnici_FK = x.Korisnici_FK,
                                Opis = x.Opis,
                                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                                ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                                proj_plan = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == y.ProjekatPlan_FK).FirstOrDefault(),
                                OrgJed = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == (int)HttpContext.Session.GetInt32("orgJed ID")).FirstOrDefault()
                            });
                        }
                    }
                }

                ViewData["lista_relizacija"] = par_temp_2;

                return View("Prikaz");
            }
        }
    }
}