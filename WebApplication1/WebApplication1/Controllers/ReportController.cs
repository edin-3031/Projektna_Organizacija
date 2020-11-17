using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using WebApplication1.Data;
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
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Misc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Hosting;
using SelectPdf;
using Aspose.Pdf;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace WebApplication1.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext db;

        public ReportController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public lista_realizacijaVM DobavljanjePodataka(int o, int projekatId = 0, DateTime? OD = null, DateTime? DO = null, int traziDugme = 10) {


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

            if (projekatId == 0 && (OD != null || DO != null))
            {
                List<ProjekatAktivnostPlan> lista_pro_aktiv_plan = new List<ProjekatAktivnostPlan>();

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
                        projekatId=projekatId,
                        Do=DO.Value,
                        Od=OD.Value,
                        organizacijaId=o
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
                        projekatId = projekatId,
                        Do = DO.Value,
                        organizacijaId = o
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
                        projekatId = projekatId,
                        Od = OD.Value,
                        organizacijaId = o
                    };

                    return model;
                }
            }











            else if (projekatId == 0 && (OD != null && DO != null))
            {

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
                    projekatId = projekatId,
                    Do = DO.Value,
                    Od = OD.Value,
                    organizacijaId = o
                };

                ViewData["lista_projekata"] = lista;
                return model;
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
                            projekatId = projekatId,
                            Do = DO.Value,
                            Od = OD.Value,
                            organizacijaId = o
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
                            projekatId = projekatId,
                            Do = DO.Value,
                            Od = OD.Value,
                            organizacijaId = o
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
                            projekatId = projekatId,
                            Do = DO.Value,
                            Od = OD.Value,
                            organizacijaId = o
                        };

                        return model;
                    }
                }
            }

            if (traziDugme == 10 && projekatId == 0 && OD == null && DO == null)
            {

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
                    projekatId = projekatId,
                    organizacijaId = o
                };

                return  model;
            }

            lista_realizacijaVM model2 = new lista_realizacijaVM()
            {
                liste = null
            };
            return model2;
        }

        public IActionResult Index(int uloga, int organizacijaId, int projekatId = 0, DateTime? OD = null, DateTime? DO = null, int? dugme = 0)
        {
            if (OD != null)
            {
                if (OD.Value.Year == 1)
                    OD = null;
            }
            if (DO != null)
            {
                if (DO.Value.Year == 1)
                    DO = null;
            }
            lista_realizacijaVM m = new lista_realizacijaVM();

            switch (uloga)
            {
                case 1: m=DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                case 2: m=DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                case 3: m=DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                case 7: m=DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                default:break;
            }

            return View(m);
        }

        public IActionResult Index2(int uloga, int organizacijaId, int projekatId = 0, DateTime? OD = null, DateTime? DO = null, int? dugme = 10)
        {
            if (OD != null)
            {
                if (OD.Value.Year == 1)
                    OD = null;
            }
            if (DO != null)
            {
                if (DO.Value.Year == 1)
                    DO = null;
            }
            lista_realizacijaVM m = new lista_realizacijaVM();

            switch (uloga)
            {
                case 1: m = DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                case 2: m = DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                case 3: m = DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                case 7: m = DobavljanjePodataka(organizacijaId, projekatId, OD, DO); break;
                default: break;
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Detalji realizacija");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Realizacija ID";
                worksheet.Cell(currentRow, 2).Value = "Projekat ID";
                worksheet.Cell(currentRow, 3).Value = "Naziv projekta";
                worksheet.Cell(currentRow, 4).Value = "Aktivnost ID";
                worksheet.Cell(currentRow, 5).Value = "Naziv aktivnosti";
                worksheet.Cell(currentRow, 6).Value = "Korisnik ID";
                worksheet.Cell(currentRow, 7).Value = "Korisnik";
                worksheet.Cell(currentRow, 8).Value = "Datum";
                worksheet.Cell(currentRow, 9).Value = "Planirana količina";
                worksheet.Cell(currentRow, 10).Value = "Ostvarna količina";
                worksheet.Cell(currentRow, 11).Value = "Procentualno (%)";

                foreach (var x in m.liste)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.realizacijaId;
                    worksheet.Cell(currentRow, 2).Value = x.projekatId;
                    worksheet.Cell(currentRow, 3).Value = x.nazivProjekta;
                    worksheet.Cell(currentRow, 4).Value = x.aktivnostId;
                    worksheet.Cell(currentRow, 5).Value = x.naziv_aktivnosti;
                    worksheet.Cell(currentRow, 6).Value = x.korisnikId;
                    worksheet.Cell(currentRow, 7).Value = db.Korisnici.Where(a => a.Korisnici_ID == x.korisnikId).Select(o => o.Ime.ToString() + " " + o.Prezime.ToString()).FirstOrDefault();
                    worksheet.Cell(currentRow, 8).Value = x.datum;
                    worksheet.Cell(currentRow, 9).Value = x.planirano;
                    worksheet.Cell(currentRow, 10).Value = x.odradjeno;
                    worksheet.Cell(currentRow, 11).Value = Math.Round(((x.odradjeno / x.planirano) * 100));
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DetaljiRealizacijaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        public IActionResult IndexUserAktivnost(int o)
        {
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

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Detalji AktivnostPlan");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Aktivnost";
                worksheet.Cell(currentRow, 2).Value = "Šifra";
                worksheet.Cell(currentRow, 3).Value = "Projekat";
                worksheet.Cell(currentRow, 4).Value = "Datum od";
                worksheet.Cell(currentRow, 5).Value = "Datum do";
                worksheet.Cell(currentRow, 6).Value = "Količina";
                worksheet.Cell(currentRow, 7).Value = "Jedinica mjere";

                foreach (var x in temp_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Naziv;
                    worksheet.Cell(currentRow, 2).Value = x.Sifra;
                    worksheet.Cell(currentRow, 3).Value = db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID== x.ProjekatPlan_FK).Select(o=>o.Naziv).FirstOrDefault();
                    worksheet.Cell(currentRow, 5).Value = x.DatumOd;
                    worksheet.Cell(currentRow, 4).Value = x.DatumDo;
                    worksheet.Cell(currentRow, 6).Value = x.Kolicina;
                    worksheet.Cell(currentRow, 7).Value = x.JedinicaMjere;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AktivnostPlanInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        public IActionResult IndexAdminOrgAktivnost(int o)
        {
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

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Detalji AktivnostPlan");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Aktivnost";
                worksheet.Cell(currentRow, 2).Value = "Šifra";
                worksheet.Cell(currentRow, 3).Value = "Projekat";
                worksheet.Cell(currentRow, 4).Value = "Datum od";
                worksheet.Cell(currentRow, 5).Value = "Datum do";
                worksheet.Cell(currentRow, 6).Value = "Količina";
                worksheet.Cell(currentRow, 7).Value = "Jedinica mjere";

                foreach (var x in temp_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Naziv;
                    worksheet.Cell(currentRow, 2).Value = x.Sifra;
                    worksheet.Cell(currentRow, 3).Value = db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID== x.ProjekatPlan_FK).Select(o=>o.Naziv).FirstOrDefault();
                    worksheet.Cell(currentRow, 5).Value = x.DatumOd;
                    worksheet.Cell(currentRow, 4).Value = x.DatumDo;
                    worksheet.Cell(currentRow, 6).Value = x.Kolicina;
                    worksheet.Cell(currentRow, 7).Value = x.JedinicaMjere;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AktivnostPlanInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }
    }
}
