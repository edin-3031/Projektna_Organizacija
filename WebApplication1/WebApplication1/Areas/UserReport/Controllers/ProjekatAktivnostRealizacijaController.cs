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

namespace WebApplication1.Areas.UserReport.Controllers
{
    public class ProjekatAktivnostRealizacijaController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostRealizacijaController(ApplicationDbContext _db)
        {
            db = _db;

        }
        [Area("UserReport")]
        public IActionResult Pdf()
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
        [Area("UserReport")]
        public IActionResult Excel(int u, int o, int r)
        {
            //List<ProjekatAktivnostRealizacija> _real = db.ProjekatAktivnostRealizacija.ToList();

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

            List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<excelRealizacija> realizacija_final = new List<excelRealizacija>();

            foreach (var x in temp_final)
            {
                foreach (var y in realizacija_temp)
                {
                    if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                    {
                        realizacija_final.Add(new excelRealizacija
                        {
                            aktivnost_naziv=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==y.ProjekatAktivnostPlan_FK).Select(o=>o.Naziv).FirstOrDefault(),
                            datum=y.Datum.Date,
                            kolicina=y.Kolicina,
                            korisnik_ime=db.Korisnici.Where(a=>a.Korisnici_ID==y.Korisnici_FK).Select(o=>o.Ime.ToString()+" "+o.Prezime.ToString()).FirstOrDefault(),
                            opis=y.Opis,
                            projekat_naziv=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID== db.ProjekatAktivnostPlan.Where(b => b.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).Select(p => p.ProjekatPlan_FK).FirstOrDefault()).Select(t=>t.Naziv).FirstOrDefault()
                        });
                    }
                }
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Realizacija");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Projekat";
                worksheet.Cell(currentRow, 2).Value = "Aktivnost";
                worksheet.Cell(currentRow, 3).Value = "Korisnik";
                worksheet.Cell(currentRow, 4).Value = "Datum";
                worksheet.Cell(currentRow, 5).Value = "Količina";
                worksheet.Cell(currentRow, 6).Value = "Opis";

                foreach (var x in realizacija_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.projekat_naziv;
                    worksheet.Cell(currentRow, 2).Value = x.aktivnost_naziv;
                    worksheet.Cell(currentRow, 3).Value = x.korisnik_ime;
                    worksheet.Cell(currentRow, 4).Value = x.datum;
                    worksheet.Cell(currentRow, 5).Value = x.kolicina;
                    worksheet.Cell(currentRow, 6).Value = x.opis;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "RealizacijaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }
        [Area("UserReport")]
        public IActionResult PrintPreview(int u, int o, int r)
        {
            //List<ProjekatAktivnostRealizacija> _real = db.ProjekatAktivnostRealizacija.ToList();

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

            List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<ProjekatAktivnostRealizacija> realizacija_final = new List<ProjekatAktivnostRealizacija>();

            foreach (var x in temp_final)
            {
                foreach (var y in realizacija_temp)
                {
                    if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                    {
                        realizacija_final.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = y.Datum,
                            ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                            Kolicina = y.Kolicina,
                            Korisnici_FK = y.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                            Opis = y.Opis,
                            projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                        });
                    }
                }
            }

            List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();
            foreach (var x in realizacija_final)
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
                lista = _lista,
                
            };

            return View(model);
        }

        [Area("UserReport")]
        public IActionResult Detalji(int u, int o, int r, int projekatId = 0, DateTime? OD = null, DateTime? DO = null, int traziDugme = 0)
        {


            ////Dobavljanje liste projekata za birajuću listu
            //List<ProjekatPlan> projekti = db.ProjekatPlan.Select(x => new ProjekatPlan
            //{
            //    //DatumDo = x.DatumDo,
            //    //DatumOd = x.DatumOd,
            //    Naziv = x.Naziv,
            //    ProjekatPlan_ID = x.ProjekatPlan_ID
            //}).ToList();

            //ViewData["projekti"] = projekti;

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
            List<ProjekatPlan> projekti = new List<ProjekatPlan>();

            foreach (var x in p_p)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        projekti.Add(new ProjekatPlan
                        {
                            Naziv = x.Naziv,
                            ProjekatPlan_ID = x.ProjekatPlan_ID
                        });
                    }
                }
            }

            ViewData["projekti"] = projekti;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };
            ViewData["id"] = podaci;
















            if (projekatId == 0 && (OD != null || DO != null))
            {
                List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

                //List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

                //List<ProjekatPlan> p_p = db.ProjekatPlan.ToList();
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

                List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                foreach (var x in temp_final)
                {
                    foreach (var y in realizacija_temp)
                    {
                        if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                        {
                            par.Add(new ProjekatAktivnostRealizacija
                            {
                                Datum = y.Datum,
                                ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                                Kolicina = y.Kolicina,
                                Korisnici_FK = y.Korisnici_FK,
                                korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                                Opis = y.Opis,
                                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                            });
                        }
                    }
                }

                ViewData["lista_relizacija"] = par;

                //List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
                //{
                //    Datum=x.Datum,
                //    Kolicina=x.Kolicina,
                //    korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
                //    Korisnici_FK=x.Korisnici_FK,
                //    Opis=x.Opis,
                //    projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                //    ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
                //    ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID
                //}).ToList();

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
                                aktivnostId = x.ProjekatAktivnostPlan_FK,
                                datum = x.Datum,
                                korisnikId = x.Korisnici_FK,
                                naziv_aktivnosti = x.projekatAktivnostPlan.Naziv,
                                odradjeno = x.Kolicina,
                                planirano = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK && a.ProjekatPlan_FK == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Kolicina).FirstOrDefault(),
                                nazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == x.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                projekatId = x.ProjekatAktivnostPlan_FK,
                                realizacijaId = x.ProjekatAktivnostRealizacija_ID,
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
                        Do=DO.Value,
                        projekatId=projekatId,
                        organizacijaId=o,
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
                        Od=OD.Value,
                        organizacijaId=o,
                        projekatId=projekatId
                    };

                    return View(model);
                }
            }











            else if (projekatId == 0 && (OD != null && DO != null))
            {
                //List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
                //{
                //    Datum = x.Datum,
                //    Kolicina = x.Kolicina,
                //    korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                //    Korisnici_FK = x.Korisnici_FK,
                //    Opis = x.Opis,
                //    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                //    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                //    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                //}).ToList();

                List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

                List<OrganizacionaJedinica> org_jed_2 = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

                List<ProjekatPlan> p_p_2 = db.ProjekatPlan.ToList();
                List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

                foreach (var x in p_p_2)
                {
                    foreach (var y in org_jed_2)
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

                List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                foreach (var x in temp_final)
                {
                    foreach (var y in realizacija_temp)
                    {
                        if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                        {
                            par.Add(new ProjekatAktivnostRealizacija
                            {
                                Datum = y.Datum,
                                ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                                Kolicina = y.Kolicina,
                                Korisnici_FK = y.Korisnici_FK,
                                korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                                Opis = y.Opis,
                                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                            });
                        }
                    }
                }

                //ViewData["lista_relizacija"] = par;

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
                    projekatId=projekatId,
                    organizacijaId=o,
                    Od=OD.Value,
                    Do=DO.Value
                };

                ViewData["lista_projekata"] = lista;
                return View(model);
            }

            else if (projekatId >= 1)
            {
                RealizacijaDetaljiSuma suma = new RealizacijaDetaljiSuma
                {
                    naziv_projekta = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == projekatId).Select(o => o.Naziv).FirstOrDefault(),
                    ostvareno = 0,
                    planirano = 0,
                    procenti = 0,
                    ProjekatId = projekatId
                };

                List<ProjekatAktivnostPlan> pap = db.ProjekatAktivnostPlan.Where(y => y.ProjekatPlan_FK == projekatId).Select(x => new ProjekatAktivnostPlan
                {
                    DatumDo = x.DatumDo,
                    DatumOd = x.DatumOd,
                    JedinicaMjere = x.JedinicaMjere,
                    Kolicina = x.Kolicina,
                    Naziv = x.Naziv,
                    ProjekatAktivnostPlan_ID = x.ProjekatAktivnostPlan_ID,
                    projekatPlan = db.ProjekatPlan.Where(v => v.ProjekatPlan_ID == x.ProjekatPlan_FK).FirstOrDefault(),
                    ProjekatPlan_FK = x.ProjekatPlan_FK,
                    Sifra = x.Sifra
                }).ToList();

                List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

                List<OrganizacionaJedinica> org_jed_3 = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

                List<ProjekatPlan> p_p_3 = db.ProjekatPlan.ToList();
                List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

                foreach (var x in p_p_3)
                {
                    foreach (var y in org_jed_3)
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

                List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                foreach (var x in temp_final)
                {
                    foreach (var y in realizacija_temp)
                    {
                        if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                        {
                            par.Add(new ProjekatAktivnostRealizacija
                            {
                                Datum = y.Datum,
                                ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                                Kolicina = y.Kolicina,
                                Korisnici_FK = y.Korisnici_FK,
                                korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                                Opis = y.Opis,
                                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                            });
                        }
                    }
                }

                //ViewData["lista_relizacija"] = par;

                //List<ProjekatAktivnostRealizacija> lista_par = db.ProjekatAktivnostRealizacija.ToList();
                //List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();



                //foreach(var x in pap)
                //{
                //    foreach(var y in lista_par)
                //    {
                //        if (x.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK)
                //        {
                //            par.Add(new ProjekatAktivnostRealizacija
                //            {
                //               Datum=db.ProjekatAktivnostRealizacija.Where(a=>a.ProjekatAktivnostRealizacija_ID==y.ProjekatAktivnostRealizacija_ID).Select(o=>o.Datum).FirstOrDefault(),
                //               Kolicina= db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Kolicina).FirstOrDefault(),
                //               Opis= db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == y.ProjekatAktivnostRealizacija_ID).Select(o => o.Opis).FirstOrDefault(),
                //               ProjekatAktivnostRealizacija_ID=y.ProjekatAktivnostRealizacija_ID,
                //               ProjekatAktivnostPlan_FK=y.ProjekatAktivnostPlan_FK,
                //               projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                //               Korisnici_FK=y.Korisnici_FK,
                //               korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==y.Korisnici_FK).FirstOrDefault()
                //            });
                //        }
                //    }
                //}

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

                        List<RealizacijaVM> lista_final = new List<RealizacijaVM>();

                        string proj_plan_naziv = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == projekatId).Select(o => o.Naziv).FirstOrDefault();

                        foreach (var x in lista)
                        {
                            if (x.nazivProjekta == proj_plan_naziv)
                            {
                                lista_final.Add(new RealizacijaVM
                                {
                                    aktivnostId = x.aktivnostId,
                                    projekatId = x.projekatId,
                                    datum = x.datum,
                                    korisnikId = x.korisnikId,
                                    nazivProjekta = x.nazivProjekta,
                                    naziv_aktivnosti = x.naziv_aktivnosti,
                                    odradjeno = x.odradjeno,
                                    planirano = x.planirano,
                                    realizacijaId = x.realizacijaId
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista_final,
                            projekatId = projekatId,
                            organizacijaId = o
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
                            projekatId = projekatId,
                            organizacijaId = o,
                            Od = OD.Value,
                            Do = DO.Value
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
                            projekatId = projekatId,
                            organizacijaId = o,
                            Od = OD.Value,
                            Do = DO.Value
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
                            projekatId = projekatId,
                            organizacijaId = o,
                            Od = OD.Value,
                            Do = DO.Value
                        };

                        return View(model);
                    }
                }
            }

            if (traziDugme == 10 && projekatId == 0 && OD == null && DO == null)
            {
                //List<ProjekatAktivnostRealizacija> par = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
                //{
                //    Datum = x.Datum,
                //    Kolicina = x.Kolicina,
                //    korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                //    Korisnici_FK = x.Korisnici_FK,
                //    Opis = x.Opis,
                //    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                //    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                //    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
                //}).ToList();

                List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

                List<OrganizacionaJedinica> org_jed_4 = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

                List<ProjekatPlan> p_p_4 = db.ProjekatPlan.ToList();
                List<ProjekatPlan> p_p_final = new List<ProjekatPlan>();

                foreach (var x in p_p_4)
                {
                    foreach (var y in org_jed_4)
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

                List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                foreach (var x in temp_final)
                {
                    foreach (var y in realizacija_temp)
                    {
                        if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                        {
                            par.Add(new ProjekatAktivnostRealizacija
                            {
                                Datum = y.Datum,
                                ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                                Kolicina = y.Kolicina,
                                Korisnici_FK = y.Korisnici_FK,
                                korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                                Opis = y.Opis,
                                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                                ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                            });
                        }
                    }
                }

                //ViewData["lista_relizacija"] = par;

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
                    organizacijaId = o
                };

                return View(model);
            }

            lista_realizacijaVM model2 = new lista_realizacijaVM()
            {
                liste = null
            };
            return View(model2);
        }

        [Area("UserReport")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            //List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            //{
            //    Datum=x.Datum,
            //    Kolicina=x.Kolicina,
            //    korisnici=db.Korisnici.Where(c=>c.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
            //    Korisnici_FK=x.Korisnici_FK,
            //    Opis=x.Opis,
            //    projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(c=>c.ProjekatAktivnostPlan_ID==x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
            //    ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID
            //}).ToList();
            //ViewData["lista_relizacija"] = lista;

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

            List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<ProjekatAktivnostRealizacija> realizacija_final = new List<ProjekatAktivnostRealizacija>();

            foreach (var x in temp_final)
            {
                foreach (var y in realizacija_temp)
                {
                    if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                    {
                        realizacija_final.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = y.Datum,
                            ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                            Kolicina = y.Kolicina,
                            Korisnici_FK = y.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                            Opis = y.Opis,
                            projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                        });
                    }
                }
            }

            ViewData["lista_relizacija"] = realizacija_final;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }


        [Area("UserReport")]
        public IActionResult Unos(int u, int o, int r)
        {
            //List<ProjekatAktivnostPlan> lista_proj_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            //{
            //    ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID,
            //    Naziv=x.Naziv
            //}).ToList();
            //ViewData["lista_proj_aktiv_plan"] = lista_proj_aktiv_plan;

            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<ProjekatPlan> lista_proj_plan_temp = db.ProjekatPlan.ToList();
            List<ProjekatPlan> lista_proj_plan = new List<ProjekatPlan>();

            foreach (var x in lista_proj_plan_temp)
            {
                foreach (var y in lista_org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        lista_proj_plan.Add(new ProjekatPlan
                        {
                            DatumDo = x.DatumDo,
                            DatumOd = x.DatumOd,
                            Naziv = x.Naziv,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                            ProjekatPlan_ID = x.ProjekatPlan_ID,
                            Sifra = x.Sifra
                        });
                    }
                }
            }
            List<ProjekatAktivnostPlan> lista_proj_aktiv_plan_temp = db.ProjekatAktivnostPlan.ToList();
            List<ProjekatAktivnostPlan> lista_proj_aktiv_plan = new List<ProjekatAktivnostPlan>();

            foreach (var x in lista_proj_aktiv_plan_temp)
            {
                foreach (var y in lista_proj_plan)
                {
                    if (x.ProjekatPlan_FK == y.ProjekatPlan_ID)
                    {
                        lista_proj_aktiv_plan.Add(new ProjekatAktivnostPlan
                        {
                            DatumDo = y.DatumDo,
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

            ViewData["lista_proj_aktiv_plan"] = lista_proj_aktiv_plan;

            //List<Korisnici> lista_korisnici = db.Korisnici.Select(x => new Korisnici
            //{
            //    Korisnici_ID=x.Korisnici_ID,
            //    Ime=x.Ime,
            //    Prezime=x.Prezime
            //}).ToList();
            //ViewData["lista_korisnici"] = lista_korisnici;

            List<Korisnici_OrganizacionaJedinica> lista_kor_org_jed_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> lista_kor_org_jed = new List<Korisnici_OrganizacionaJedinica>();
            List<OrganizacionaJedinica> lista_org_jed_2 = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

            foreach (var x in lista_kor_org_jed_temp)
            {
                foreach (var y in lista_org_jed_2)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        lista_kor_org_jed.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK = x.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault(),
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK
                        });
                    }
                }
            }

            List<Korisnici> lista_kor_temp = db.Korisnici.ToList();
            List<Korisnici> lista_kor = new List<Korisnici>();
            bool postoji = false;
            foreach (var x in lista_kor_temp)
            {
                foreach (var y in lista_kor_org_jed)
                {
                    if (x.Korisnici_ID == y.Korisnici_FK)
                    {
                        postoji = false;

                        if (lista_kor.Count == 0)
                        {
                            lista_kor.Add(new Korisnici
                            {
                                Ime = x.Ime,
                                Prezime = x.Prezime,
                                Korisnici_ID = x.Korisnici_ID
                            });
                        }
                        else
                        {
                            foreach (var z in lista_kor)
                            {
                                if (z.Korisnici_ID == x.Korisnici_ID)
                                    postoji = true;
                            }
                            if (!postoji)
                            {
                                lista_kor.Add(new Korisnici
                                {
                                    Ime = x.Ime,
                                    Prezime = x.Prezime,
                                    Korisnici_ID = x.Korisnici_ID
                                });
                            }
                        }
                    }
                }
            }

            ViewData["lista_korisnici"] = lista_kor;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View();
        }



        [Area("UserReport")]
        public IActionResult UnosSnimi(int projekatAktivnostPlan, int korisnik, DateTime datum, float kolicina, string opis, int u, int o, int r)
        {
            ProjekatAktivnostRealizacija temp_2 = new ProjekatAktivnostRealizacija
            {
                Datum = datum,
                Kolicina = kolicina,
                Korisnici_FK = korisnik,
                Opis = opis,
                ProjekatAktivnostPlan_FK = projekatAktivnostPlan
            };

            db.ProjekatAktivnostRealizacija.Add(temp_2);
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

            List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<ProjekatAktivnostRealizacija> realizacija_final = new List<ProjekatAktivnostRealizacija>();

            foreach (var x in temp_final)
            {
                foreach (var y in realizacija_temp)
                {
                    if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                    {
                        realizacija_final.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = y.Datum,
                            ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                            Kolicina = y.Kolicina,
                            Korisnici_FK = y.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                            Opis = y.Opis,
                            projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                        });
                    }
                }
            }

            ViewData["lista_relizacija"] = realizacija_final;

            //List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            //{
            //    Datum = x.Datum,
            //    Kolicina = x.Kolicina,
            //    korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
            //    Korisnici_FK = x.Korisnici_FK,
            //    Opis = x.Opis,
            //    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(c => c.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
            //    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            //}).ToList();
            //ViewData["lista_relizacija"] = lista;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("UserReport")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            ProjekatAktivnostRealizacija temp_2 = db.ProjekatAktivnostRealizacija.Where(x => x.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

            if (temp_2 != null)
            {
                db.ProjekatAktivnostRealizacija.Remove(temp_2);
                db.SaveChanges();
            }

            //List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            //{
            //    Datum = x.Datum,
            //    Kolicina = x.Kolicina,
            //    korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
            //    Korisnici_FK = x.Korisnici_FK,
            //    Opis = x.Opis,
            //    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(c => c.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
            //    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            //}).ToList();
            //ViewData["lista_relizacija"] = lista;

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

            List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<ProjekatAktivnostRealizacija> realizacija_final = new List<ProjekatAktivnostRealizacija>();

            foreach (var x in temp_final)
            {
                foreach (var y in realizacija_temp)
                {
                    if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                    {
                        realizacija_final.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = y.Datum,
                            ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                            Kolicina = y.Kolicina,
                            Korisnici_FK = y.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                            Opis = y.Opis,
                            projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                        });
                    }
                }
            }

            ViewData["lista_relizacija"] = realizacija_final;

            uor podaci = new uor
            {
                roleId = r,
                organisationId = o,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
        [Area("UserReport")]
        public IActionResult Uredi(int id, int u, int o, int r)
        {
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
        [Area("UserReport")]
        public IActionResult UrediSnimi(int realizacijaId, int aktivnostId, string projekat, float kolicina, DateTime datum, string opis, int u, int o, int r)
        {
            ProjekatAktivnostRealizacija temp_2 = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == realizacijaId).FirstOrDefault();

            temp_2.Kolicina = kolicina;
            temp_2.Opis = opis;
            temp_2.Datum = datum;

            db.Update(temp_2);
            db.SaveChanges();

            //List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            //{
            //    Datum = x.Datum,
            //    Kolicina = x.Kolicina,
            //    korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
            //    Korisnici_FK = x.Korisnici_FK,
            //    Opis = x.Opis,
            //    projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(c => c.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
            //    ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
            //    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            //}).ToList();
            //ViewData["lista_relizacija"] = lista;

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

            List<ProjekatAktivnostRealizacija> realizacija_temp = db.ProjekatAktivnostRealizacija.ToList();
            List<ProjekatAktivnostRealizacija> realizacija_final = new List<ProjekatAktivnostRealizacija>();

            foreach (var x in temp_final)
            {
                foreach (var y in realizacija_temp)
                {
                    if (y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID)
                    {
                        realizacija_final.Add(new ProjekatAktivnostRealizacija
                        {
                            Datum = y.Datum,
                            ProjekatAktivnostPlan_FK = y.ProjekatAktivnostPlan_FK,
                            Kolicina = y.Kolicina,
                            Korisnici_FK = y.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == y.Korisnici_FK).FirstOrDefault(),
                            Opis = y.Opis,
                            projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == y.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                            ProjekatAktivnostRealizacija_ID = y.ProjekatAktivnostRealizacija_ID
                        });
                    }
                }
            }

            ViewData["lista_relizacija"] = realizacija_final;

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