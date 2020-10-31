﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Detalji(int projekatId = 0, DateTime? OD=null, DateTime? DO=null)
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

            if (projekatId == 0)
            {
                List<RealizacijaVM> lista = db.ProjekatAktivnostPlan.Select(x => new RealizacijaVM
                {
                    datum = db.ProjekatAktivnostRealizacija.Where(y => y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID).Select(o => o.Datum.Date).FirstOrDefault(),
                    odradjeno = db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID).Select(o => o.Kolicina).FirstOrDefault(),
                    planirano=x.Kolicina,
                    projekatId = x.ProjekatPlan_FK,
                    nazivProjekta = db.ProjekatPlan.Where(b => b.ProjekatPlan_ID == x.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                    realizacijaId=db.ProjekatAktivnostRealizacija.Where(v=>v.ProjekatAktivnostPlan_FK==x.ProjekatAktivnostPlan_ID).Select(o=>o.ProjekatAktivnostRealizacija_ID).FirstOrDefault()
                }).ToList();
                lista_realizacijaVM model = new lista_realizacijaVM
                {
                    liste = lista
                };

                ViewData["lista_projekata"] = lista;
                return View(model);
            }

            else if (projekatId >= 1)
            {
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

                List<ProjekatAktivnostRealizacija> par = new List<ProjekatAktivnostRealizacija>();

                foreach(var t in pap)
                {
                    par.Add(new ProjekatAktivnostRealizacija
                    {
                       Datum=db.ProjekatAktivnostRealizacija.Where(c=>c.ProjekatAktivnostPlan_FK==t.ProjekatAktivnostPlan_ID).Select(o=>o.Datum).FirstOrDefault(),
                       Kolicina= db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o => o.Kolicina).FirstOrDefault(),
                       Korisnici_FK= db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o => o.Korisnici_FK).FirstOrDefault(),
                       Opis= db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o => o.Opis).FirstOrDefault(),
                       ProjekatAktivnostPlan_FK= db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o => o.ProjekatAktivnostPlan_FK).FirstOrDefault(),
                       ProjekatAktivnostRealizacija_ID= db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o => o.ProjekatAktivnostRealizacija_ID).FirstOrDefault(),
                       projekatAktivnostPlan=db.ProjekatAktivnostPlan.Where(p=>p.ProjekatAktivnostPlan_ID==t.ProjekatAktivnostPlan_ID).FirstOrDefault(),
                    });
                }

                if (pap != null)
                {

                    if (OD == null && DO == null)
                    {
                        List<RealizacijaVM> lista = db.ProjekatAktivnostPlan.Where(b=>b.ProjekatPlan_FK==projekatId).Select(x => new RealizacijaVM
                        {
                            datum = db.ProjekatAktivnostRealizacija.Where(y => y.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID).Select(o => o.Datum.Date).FirstOrDefault(),
                            odradjeno = db.ProjekatAktivnostRealizacija.Where(c => c.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID).Select(o => o.Kolicina).FirstOrDefault(),
                            planirano = x.Kolicina,
                            projekatId = x.ProjekatPlan_FK,
                            nazivProjekta = db.ProjekatPlan.Where(b => b.ProjekatPlan_ID == x.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                            realizacijaId = db.ProjekatAktivnostRealizacija.Where(v => v.ProjekatAktivnostPlan_FK == x.ProjekatAktivnostPlan_ID).Select(o => o.ProjekatAktivnostRealizacija_ID).FirstOrDefault()
                        }).ToList();
                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista
                        };

                        return View(model);
                    }

                    else if (OD != null && DO == null)
                    {
                        List<RealizacijaVM> lista = new List<RealizacijaVM>();

                        foreach(var b in par)
                        {
                            if(b.Datum.Year >= OD.Value.Year && b.Datum.Month >= OD.Value.Month && b.Datum.Day >= OD.Value.Day)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    datum=b.Datum,
                                    nazivProjekta= db.ProjekatPlan.Where(c=>c.ProjekatPlan_ID== b.projekatAktivnostPlan.ProjekatPlan_FK).Select(o=>o.Naziv).FirstOrDefault(),
                                    planirano = b.projekatAktivnostPlan.Kolicina,
                                    odradjeno =b.Kolicina,
                                    projekatId= db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == b.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.ProjekatPlan_ID).FirstOrDefault(),
                                    realizacijaId =b.ProjekatAktivnostRealizacija_ID
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista
                        };

                        return View(model);
                    }

                    else if (DO != null && OD == null)
                    {
                        List<RealizacijaVM> lista = new List<RealizacijaVM>();

                        foreach (var b in par)
                        {
                            if (b.Datum.Year <= DO.Value.Year && b.Datum.Month <= DO.Value.Month && b.Datum.Day <= DO.Value.Day)
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    datum = b.Datum,
                                    nazivProjekta = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == b.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                    planirano = b.projekatAktivnostPlan.Kolicina,
                                    odradjeno = b.Kolicina,
                                    projekatId = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == b.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.ProjekatPlan_ID).FirstOrDefault(),
                                    realizacijaId = b.ProjekatAktivnostRealizacija_ID
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista
                        };

                        return View(model);
                    }

                    else
                    {
                        List<RealizacijaVM> lista = new List<RealizacijaVM>();

                        foreach (var b in par)
                        {
                            if ((b.Datum.Year <= DO.Value.Year && b.Datum.Month <= DO.Value.Month && b.Datum.Day <= DO.Value.Day) && (b.Datum.Year >= OD.Value.Year && b.Datum.Month >= OD.Value.Month && b.Datum.Day >= OD.Value.Day))
                            {
                                lista.Add(new RealizacijaVM
                                {
                                    datum = b.Datum,
                                    nazivProjekta = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == b.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.Naziv).FirstOrDefault(),
                                    planirano = b.projekatAktivnostPlan.Kolicina,
                                    odradjeno = b.Kolicina,
                                    projekatId = db.ProjekatPlan.Where(c => c.ProjekatPlan_ID == b.projekatAktivnostPlan.ProjekatPlan_FK).Select(o => o.ProjekatPlan_ID).FirstOrDefault(),
                                    realizacijaId = b.ProjekatAktivnostRealizacija_ID
                                });
                            }
                        }

                        lista_realizacijaVM model = new lista_realizacijaVM
                        {
                            liste = lista
                        };

                        return View(model);
                    }
                }
            }

            return View();
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

    }
}