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

namespace WebApplication1.Areas.AdminOrg.Controllers
{
    public class ProjekatAktivnostRealizacijaController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostRealizacijaController(ApplicationDbContext _db)
        {
            db = _db;

        }
        [Area("AdminOrg")]
        public IActionResult Pdf(int o)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            var document = new Document
            {
                PageInfo = new PageInfo
                {
                    Margin=new MarginInfo(28,28,28,40)
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
            table.ImportDataTable(dt,true,0,0);
            document.Pages[1].Paragraphs.Add(table);

            using(var streamout=new MemoryStream())
            {
                document.Save(streamout);
                return new FileContentResult(streamout.ToArray(), "application/pdf")
                {
                    FileDownloadName = "Realizacija.pdf"
                };
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
        [Area("AdminOrg")]
        public IActionResult Excel(int o)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            List<OrganizacionaJedinica> oj_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

            foreach (var x in pp_temp)
            {
                foreach (var y in oj_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        pp_final.Add(new ProjekatPlan
                        {
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<pap_finalVM> pap_final = new List<pap_finalVM>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_final)
                {
                    if (y.ProjekatPlan_ID == x.ProjekatPlan_FK)
                    {
                        pap_final.Add(new pap_finalVM
                        {
                            projekatPlan_fk = x.ProjekatPlan_FK,
                            projekatAktivnost_Id = x.ProjekatAktivnostPlan_ID,
                            o_j_all = y.organizacionaJedinica
                        });
                    }
                }
            }

            List<ProjekatAktivnostRealizacija> p_a_r_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<par_final_VM> p_a_r_final = new List<par_final_VM>();

            foreach (var x in p_a_r_temp)
            {
                foreach (var y in pap_final)
                {
                    if (x.ProjekatAktivnostPlan_FK == y.projekatAktivnost_Id)
                    {
                        p_a_r_final.Add(new par_final_VM
                        {
                            Datum = x.Datum,
                            Kolicina = x.Kolicina,
                            Korisnici_FK = x.Korisnici_FK,
                            Opis = x.Opis,
                            OrgJed = y.o_j_all,
                            ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                            Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            proj_plan=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==y.projekatPlan_fk).FirstOrDefault()
                        });
                    }
                }
            }

            using (var workbook=new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Realizacija");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Projekat Plan";
                worksheet.Cell(currentRow, 2).Value = "Projekat Aktivnost Plan";
                worksheet.Cell(currentRow, 3).Value = "Organizaciona Jedinica";
                worksheet.Cell(currentRow, 4).Value = "Korisnik";
                worksheet.Cell(currentRow, 5).Value = "Datum";
                worksheet.Cell(currentRow, 6).Value = "Količina";
                worksheet.Cell(currentRow, 7).Value = "Opis";

                foreach(var x in p_a_r_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.proj_plan.Naziv;
                    worksheet.Cell(currentRow, 2).Value = x.ProjekatAktivnostPlan_all.Naziv;
                    worksheet.Cell(currentRow, 3).Value = x.OrgJed.Naziv;
                    worksheet.Cell(currentRow, 4).Value = x.Korisnici.Ime.ToString() + " " + x.Korisnici.Prezime.ToString();
                    worksheet.Cell(currentRow, 5).Value = x.Datum.Date.Day + "." + x.Datum.Date.Month+"."+ x.Datum.Date.Year+".";
                    worksheet.Cell(currentRow, 6).Value = x.Kolicina;
                    worksheet.Cell(currentRow, 7).Value = x.Opis;
                }

                using (var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "RealizacijaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }
        [Area("AdminOrg")]
        public IActionResult PrintPreview(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            List<ProjekatAktivnostRealizacija> _real = db.ProjekatAktivnostRealizacija.ToList();

            List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();
            foreach(var x in _real)
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
                lista=_lista
            };

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View(model);
        }
        [Area("AdminOrg")]
        public IActionResult Detalji(int u, int o, int r, int projekatId = 0, DateTime? OD=null, DateTime? DO=null, int traziDugme=0)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;


            List<OrganizacionaJedinica> oj_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<ProjekatPlan> proj_plan_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> proj_plan_final= new List<ProjekatPlan>();

            foreach(var x in proj_plan_temp)
            {
                foreach(var y in oj_lista)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        proj_plan_final.Add(new ProjekatPlan
                        {
                            ProjekatPlan_ID=x.ProjekatPlan_ID,
                            Naziv=x.Naziv,
                            organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["projekti"] = proj_plan_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            if (projekatId == 0 && (OD != null || DO != null))
            {
                List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
                {
                    Datum=x.Datum,
                    Kolicina=x.Kolicina,
                    korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
                    Korisnici_FK=x.Korisnici_FK,
                    Opis=x.Opis,
                    projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                    ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
                    ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID
                }).ToList();

                //List<RealizacijaVM> lista = new List<RealizacijaVM>();

                if (OD != null && DO!=null)
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
                        Do=DO.Value,
                        Od=OD.Value,
                        organizacijaId=o,
                        projekatId=projekatId
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
                        organizacijaId = o,
                        projekatId = projekatId
                    };

                    return View(model);
                }
                else if(OD != null)
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
                        organizacijaId = o,
                        projekatId = projekatId
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
                    organizacijaId = o,
                    projekatId = projekatId
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
                    organizacionaJedinica= o_j_temp.Naziv,
                    organizacionaJedinicaId= o_j_temp.OrganizacionaJedinica_ID
                };

                List<ProjekatAktivnostPlan> pap = db.ProjekatAktivnostPlan.Where(y => y.ProjekatPlan_FK == projekatId).Select(x => new ProjekatAktivnostPlan
                {
                    DatumDo=x.DatumDo,
                    DatumOd=x.DatumOd,
                    JedinicaMjere=x.JedinicaMjere,
                    Kolicina=x.Kolicina,
                    Naziv=x.Naziv,
                    ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID,
                    projekatPlan=db.ProjekatPlan.Where(v=>v.ProjekatPlan_ID==x.ProjekatPlan_FK).FirstOrDefault(),
                    ProjekatPlan_FK=x.ProjekatPlan_FK,
                    Sifra=x.Sifra
                }).ToList();

                List<ProjekatAktivnostRealizacija> lista_par = db.ProjekatAktivnostRealizacija.ToList();
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                foreach(var x in pap)
                {
                    foreach(var y in lista_par)
                    {
                        if (x.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK)
                        {
                            par.Add(new ProjekatAktivnostRealizacija
                            {
                               Datum=db.ProjekatAktivnostRealizacija.Where(a=>a.ProjekatAktivnostRealizacija_ID==y.ProjekatAktivnostRealizacija_ID).Select(o=>o.Datum).FirstOrDefault(),
                               Kolicina= db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Kolicina).FirstOrDefault(),
                               Opis= db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Opis).FirstOrDefault(),
                               ProjekatAktivnostRealizacija_ID=y.ProjekatAktivnostRealizacija_ID,
                               ProjekatAktivnostPlan_FK=y.ProjekatAktivnostPlan_FK,
                               projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                               Korisnici_FK=y.Korisnici_FK,
                               korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==y.Korisnici_FK).FirstOrDefault()
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
 
                        foreach(var x in par)
                        {
                            bool povecan = false;

                            if (lista.Count == 0) {
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
                                foreach(var t in lista)
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
                            organizacijaId = o,
                            projekatId = projekatId
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

                        foreach(var x in lista)
                        {
                            if (x.datum.Year >= OD.Value.Year && x.datum.Month >= OD.Value.Month && x.datum.Day >= OD.Value.Day)
                            {
                                lista_final.Add(new RealizacijaVM
                                {
                                    datum=x.datum,
                                    aktivnostId=x.aktivnostId,
                                    korisnikId=x.korisnikId,
                                    nazivProjekta=x.nazivProjekta,
                                    naziv_aktivnosti=x.naziv_aktivnosti,
                                    odradjeno=x.odradjeno,
                                    planirano=x.planirano,
                                    projekatId=x.projekatId,
                                    realizacijaId=x.realizacijaId
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista_final,
                            Od = OD.Value,
                            organizacijaId = o,
                            projekatId = projekatId
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
                            organizacijaId = o,
                            projekatId = projekatId
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
                            organizacijaId = o,
                            projekatId = projekatId
                        };

                        return View(model);
                    }
                }
            }

            if (traziDugme == 10 && projekatId==0 && OD==null && DO==null)
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
                    organizacijaId = o,
                    projekatId = projekatId
                };

                return View(model);
            }

            lista_realizacijaVM model2 = new lista_realizacijaVM()
            {
                liste = null
            };
            return View(model2);
        }
        [Area("AdminOrg")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            List<OrganizacionaJedinica> oj_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

            foreach(var x in pp_temp)
            {
                foreach(var y in oj_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        pp_final.Add(new ProjekatPlan
                        {
                            ProjekatPlan_ID=x.ProjekatPlan_ID,
                            OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                            organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<pap_finalVM> pap_final = new List<pap_finalVM>();

            foreach(var x in pap_temp)
            {
                foreach(var y in pp_final)
                {
                    if(y.ProjekatPlan_ID == x.ProjekatPlan_FK){
                        pap_final.Add(new pap_finalVM
                        {
                            projekatPlan_fk=x.ProjekatPlan_FK,
                            projekatAktivnost_Id=x.ProjekatAktivnostPlan_ID,
                            o_j_all=y.organizacionaJedinica
                        });
                    }
                }
            }

            List<ProjekatAktivnostRealizacija> p_a_r_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<par_final_VM> p_a_r_final =new List<par_final_VM>();

            foreach(var x in p_a_r_temp)
            {
                foreach(var y in pap_final)
                {
                    if (x.ProjekatAktivnostPlan_FK == y.projekatAktivnost_Id)
                    {
                        p_a_r_final.Add(new par_final_VM
                        {
                            Datum=x.Datum,
                            Kolicina=x.Kolicina,
                            Korisnici_FK=x.Korisnici_FK,
                            Opis=x.Opis,
                            OrgJed=y.o_j_all,
                            ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID,
                            Korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
                            ProjekatAktivnostPlan_all=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            proj_plan=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==y.projekatPlan_fk).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["lista_relizacija"] = p_a_r_final;


            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;


            return View();
        }
        [Area("AdminOrg")]
        public IActionResult Unos(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

            foreach(var x in pp_temp)
            {
                foreach(var y in org_jed_lista)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        pp_final.Add(new ProjekatPlan
                        {
                            DatumDo=x.DatumDo,
                            DatumOd=x.DatumOd,
                            Naziv=x.Naziv,
                            Sifra=x.Sifra,
                            ProjekatPlan_ID=x.ProjekatPlan_ID,
                            OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                            organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<ProjekatAktivnostPlan> p_a_p_temp = db.ProjekatAktivnostPlan.ToList();
            List<dropdownAdminOrgUnosRealVM> p_a_p_final = new List<dropdownAdminOrgUnosRealVM>();

            foreach(var x in p_a_p_temp)
            {
                foreach(var y in pp_final)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        p_a_p_final.Add(new dropdownAdminOrgUnosRealVM
                        {
                            aktivnostId=x.ProjekatAktivnostPlan_ID,
                            aktivnost=x.Naziv,
                            projekat=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==x.ProjekatPlan_FK).Select(o=>o.Naziv).FirstOrDefault(),
                            org_jed=y.organizacionaJedinica.Naziv
                        });
                    }
                }
            }
            ViewData["lista_proj_aktiv_plan"] = p_a_p_final;

            List<Korisnici_OrganizacionaJedinica> ko = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> ko_final = new List<Korisnici_OrganizacionaJedinica>();

            foreach(var x in ko)
            {
                foreach(var y in org_jed_lista)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        ko_final.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK=x.Korisnici_FK,
                            OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                            Korisnici_OrganizacionaJedinica_ID=x.Korisnici_OrganizacionaJedinica_ID,
                            korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
                            organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<Korisnici> lista_korisnika = db.Korisnici.ToList();
            List<Korisnici> lista_korisnika_final = new List<Korisnici>();

            foreach(var x in lista_korisnika)
            {
                foreach(var y in ko_final)
                {
                    if(x.Korisnici_ID == y.Korisnici_FK){
                        lista_korisnika_final.Add(new Korisnici
                        {
                            Ime=x.Ime,
                            Korisnici_ID=x.Korisnici_ID,
                            Prezime=x.Prezime
                        });
                    }
                }
            }

            ViewData["lista_korisnici"] = lista_korisnika_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int projekatAktivnostPlan, int korisnik, DateTime datum, float kolicina, string opis, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
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

            List<OrganizacionaJedinica> oj_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

            foreach (var x in pp_temp)
            {
                foreach (var y in oj_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        pp_final.Add(new ProjekatPlan
                        {
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<pap_finalVM> pap_final = new List<pap_finalVM>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_final)
                {
                    if (y.ProjekatPlan_ID == x.ProjekatPlan_FK)
                    {
                        pap_final.Add(new pap_finalVM
                        {
                            projekatPlan_fk = x.ProjekatPlan_FK,
                            projekatAktivnost_Id = x.ProjekatAktivnostPlan_ID,
                            o_j_all = y.organizacionaJedinica
                        });
                    }
                }
            }

            List<ProjekatAktivnostRealizacija> p_a_r_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<par_final_VM> p_a_r_final = new List<par_final_VM>();

            foreach (var x in p_a_r_temp)
            {
                foreach (var y in pap_final)
                {
                    if (x.ProjekatAktivnostPlan_FK == y.projekatAktivnost_Id)
                    {
                        p_a_r_final.Add(new par_final_VM
                        {
                            Datum = x.Datum,
                            Kolicina = x.Kolicina,
                            Korisnici_FK = x.Korisnici_FK,
                            Opis = x.Opis,
                            OrgJed = y.o_j_all,
                            ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                            Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["lista_relizacija"] = p_a_r_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Ukloni(int id, int o, int u, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(x => x.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

            if (temp != null)
            {
                db.ProjekatAktivnostRealizacija.Remove(temp);
                db.SaveChanges();
            }

            List<OrganizacionaJedinica> oj_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

            foreach (var x in pp_temp)
            {
                foreach (var y in oj_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        pp_final.Add(new ProjekatPlan
                        {
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<pap_finalVM> pap_final = new List<pap_finalVM>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_final)
                {
                    if (y.ProjekatPlan_ID == x.ProjekatPlan_FK)
                    {
                        pap_final.Add(new pap_finalVM
                        {
                            projekatPlan_fk = x.ProjekatPlan_FK,
                            projekatAktivnost_Id = x.ProjekatAktivnostPlan_ID,
                            o_j_all = y.organizacionaJedinica
                        });
                    }
                }
            }

            List<ProjekatAktivnostRealizacija> p_a_r_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<par_final_VM> p_a_r_final = new List<par_final_VM>();

            foreach (var x in p_a_r_temp)
            {
                foreach (var y in pap_final)
                {
                    if (x.ProjekatAktivnostPlan_FK == y.projekatAktivnost_Id)
                    {
                        p_a_r_final.Add(new par_final_VM
                        {
                            Datum = x.Datum,
                            Kolicina = x.Kolicina,
                            Korisnici_FK = x.Korisnici_FK,
                            Opis = x.Opis,
                            OrgJed = y.o_j_all,
                            ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                            Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["lista_relizacija"] = p_a_r_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

            temp.projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == temp.ProjekatAktivnostPlan_FK).FirstOrDefault();

            ViewData["uredi"] = temp;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }
        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int realizacijaId, int aktivnostId, string projekat, float kolicina, DateTime datum, string opis, int o, int u, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == realizacijaId).FirstOrDefault();

            temp.Kolicina = kolicina;
            temp.Opis = opis;
            temp.Datum = datum;

            db.Update(temp);
            db.SaveChanges();

            List<OrganizacionaJedinica> oj_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> pp_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> pp_final = new List<ProjekatPlan>();

            foreach (var x in pp_temp)
            {
                foreach (var y in oj_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        pp_final.Add(new ProjekatPlan
                        {
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }

            List<ProjekatAktivnostPlan> pap_temp = db.ProjekatAktivnostPlan.ToList();
            List<pap_finalVM> pap_final = new List<pap_finalVM>();

            foreach (var x in pap_temp)
            {
                foreach (var y in pp_final)
                {
                    if (y.ProjekatPlan_ID == x.ProjekatPlan_FK)
                    {
                        pap_final.Add(new pap_finalVM
                        {
                            projekatPlan_fk = x.ProjekatPlan_FK,
                            projekatAktivnost_Id = x.ProjekatAktivnostPlan_ID,
                            o_j_all = y.organizacionaJedinica
                        });
                    }
                }
            }

            List<ProjekatAktivnostRealizacija> p_a_r_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<par_final_VM> p_a_r_final = new List<par_final_VM>();

            foreach (var x in p_a_r_temp)
            {
                foreach (var y in pap_final)
                {
                    if (x.ProjekatAktivnostPlan_FK == y.projekatAktivnost_Id)
                    {
                        p_a_r_final.Add(new par_final_VM
                        {
                            Datum = x.Datum,
                            Kolicina = x.Kolicina,
                            Korisnici_FK = x.Korisnici_FK,
                            Opis = x.Opis,
                            OrgJed = y.o_j_all,
                            ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                            ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                            Korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            ProjekatAktivnostPlan_all = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["lista_relizacija"] = p_a_r_final;

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