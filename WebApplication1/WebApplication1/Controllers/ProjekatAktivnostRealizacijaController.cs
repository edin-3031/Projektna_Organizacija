using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Misc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Controllers
{
    public class ProjekatAktivnostRealizacijaController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProjekatAktivnostRealizacijaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Detalji(int projekatId = 0, DateTime? OD=null, DateTime? DO=null, int traziDugme=0)
        {
            //Dobavljanje liste projekata za birajuću listu
            List<ProjekatPlan> projekti = db.ProjekatPlan.Select(x => new ProjekatPlan
            {
                //DatumDo = x.DatumDo,
                //DatumOd = x.DatumOd,
                Naziv = x.Naziv,
                ProjekatPlan_ID = x.ProjekatPlan_ID
            }).ToList();

            ViewData["projekti"] = projekti;

            

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
                        liste = lista_final
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
                        liste = lista_final
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
                        liste = lista_final
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
                    liste = lista_final
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
                            liste = lista
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
                            liste = lista_final
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
                            liste = lista_final
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
                            liste = lista_final
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
                    liste = lista_final
                };

                return View(model);
            }

            lista_realizacijaVM model2 = new lista_realizacijaVM()
            {
                liste = null
            };
            return View(model2);
        }

        public IActionResult Prikaz()
        {
            List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            {
                Datum=x.Datum,
                Kolicina=x.Kolicina,
                korisnici=db.Korisnici.Where(c=>c.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
                Korisnici_FK=x.Korisnici_FK,
                Opis=x.Opis,
                projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(c=>c.ProjekatAktivnostPlan_ID==x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
                ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID
            }).ToList();
            ViewData["lista_relizacija"] = lista;

            return View();
        }

        public IActionResult Unos()
        {
            List<ProjekatAktivnostPlan> lista_proj_aktiv_plan = db.ProjekatAktivnostPlan.Select(x => new ProjekatAktivnostPlan
            {
                ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID,
                Naziv=x.Naziv
            }).ToList();
            ViewData["lista_proj_aktiv_plan"] = lista_proj_aktiv_plan;

            List<Korisnici> lista_korisnici = db.Korisnici.Select(x => new Korisnici
            {
                Korisnici_ID=x.Korisnici_ID,
                Ime=x.Ime,
                Prezime=x.Prezime
            }).ToList();
            ViewData["lista_korisnici"] = lista_korisnici;

            return View();
        }

        public IActionResult UnosSnimi(int projekatAktivnostPlan, int korisnik, DateTime datum, float kolicina, string opis)
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

            List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            {
                Datum = x.Datum,
                Kolicina = x.Kolicina,
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                Opis = x.Opis,
                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(c => c.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            }).ToList();
            ViewData["lista_relizacija"] = lista;

            return View("Prikaz");
        }

        public IActionResult Ukloni(int id)
        {
            ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(x => x.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

            if (temp != null)
            {
                db.ProjekatAktivnostRealizacija.Remove(temp);
                db.SaveChanges();
            }

            List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            {
                Datum = x.Datum,
                Kolicina = x.Kolicina,
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                Opis = x.Opis,
                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(c => c.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            }).ToList();
            ViewData["lista_relizacija"] = lista;

            return View("Prikaz");
        }

        public IActionResult Uredi(int id)
        {
            ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == id).FirstOrDefault();

            temp.projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == temp.ProjekatAktivnostPlan_FK).FirstOrDefault();

            ViewData["uredi"] = temp;

            return View();
        }

        public IActionResult UrediSnimi(int realizacijaId, int aktivnostId, string projekat, float kolicina, DateTime datum, string opis)
        {
            ProjekatAktivnostRealizacija temp = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == realizacijaId).FirstOrDefault();

            temp.Kolicina = kolicina;
            temp.Opis = opis;
            temp.Datum = datum;

            db.Update(temp);
            db.SaveChanges();

            List<ProjekatAktivnostRealizacija> lista = db.ProjekatAktivnostRealizacija.Select(x => new ProjekatAktivnostRealizacija
            {
                Datum = x.Datum,
                Kolicina = x.Kolicina,
                korisnici = db.Korisnici.Where(c => c.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                Korisnici_FK = x.Korisnici_FK,
                Opis = x.Opis,
                projekatAktivnostPlan = db.ProjekatAktivnostPlan.Where(c => c.ProjekatAktivnostPlan_ID == x.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                ProjekatAktivnostPlan_FK = x.ProjekatAktivnostPlan_FK,
                ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID
            }).ToList();
            ViewData["lista_relizacija"] = lista;

            return View("Prikaz");
        }
    }
}