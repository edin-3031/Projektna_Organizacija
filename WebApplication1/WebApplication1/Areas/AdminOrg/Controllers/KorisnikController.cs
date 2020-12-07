using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using ClosedXML.Excel;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.AdminOrg.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly ApplicationDbContext db;

        public KorisnikController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("AdminOrg")]
        public IActionResult Excel()
        {

            List<OrganizacionaJedinicaVM> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).Include(a=>a.drzava).Include(a=>a.organizacija).Include(a=>a.ptt).Select(x => new OrganizacionaJedinicaVM
            {
                Adresa=x.Adresa,
                Drzava_id=x.drzava.Drzava_ID,
                Drzava_naziv=x.drzava.Naziv,
                Naziv=x.Naziv,
                Organizacija_id=x.organizacija.Organizacija_ID,
                Organizacija_naziv=x.organizacija.Naziv,
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID,
                PTT_id=x.ptt.PTT_ID,
                PTT_naziv=x.Naziv
            }).ToList();

            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici> k_final = new List<Korisnici>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_final.Add(new Korisnici
                        {
                            Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
                            Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
                            Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
                            Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
                            Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
                            Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
                            Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
                            Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
                            Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
                            uloge = db.Uloge.Where(a => a.Uloge_ID == (db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["korisnik"] = k_final;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Korisnici");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Korisnik ID";
                worksheet.Cell(currentRow, 2).Value = "Ime i prezime";
                worksheet.Cell(currentRow, 3).Value = "Korisničko ime";
                worksheet.Cell(currentRow, 4).Value = "Lozinka";
                worksheet.Cell(currentRow, 5).Value = "Šifra";
                worksheet.Cell(currentRow, 6).Value = "Mail";
                worksheet.Cell(currentRow, 7).Value = "Telefon";
                worksheet.Cell(currentRow, 8).Value = "Uloga";

                foreach (var x in k_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Korisnici_ID;
                    worksheet.Cell(currentRow, 2).Value = x.Ime.ToString() + " " + x.Prezime.ToString();
                    worksheet.Cell(currentRow, 3).Value = x.Korisnicko_Ime;
                    worksheet.Cell(currentRow, 4).Value = x.Lozinka;
                    worksheet.Cell(currentRow, 5).Value = x.Sifra;
                    worksheet.Cell(currentRow, 6).Value = x.Mail;
                    worksheet.Cell(currentRow, 7).Value = x.Telefon;
                    worksheet.Cell(currentRow, 8).Value = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).Select(o => o.Naziv).FirstOrDefault();
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "KorisniciInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        [Area("AdminOrg")]
        public IActionResult Prikaz()
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici> k_final = new List<Korisnici>();

            foreach(var x in k_o_temp)
            {
                foreach(var y in org_jed_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_final.Add(new Korisnici
                        {
                            Ime=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Ime).FirstOrDefault(),
                            Prezime=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Prezime).FirstOrDefault(),
                            Korisnicko_Ime=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Korisnicko_Ime).FirstOrDefault(),
                            Lozinka=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Lozinka).FirstOrDefault(),
                            Mail=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Mail).FirstOrDefault(),
                            Sifra=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Sifra).FirstOrDefault(),
                            Telefon=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Telefon).FirstOrDefault(),
                            Korisnici_ID=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).Select(o=>o.Korisnici_ID).FirstOrDefault(),
                            Uloge_FK= db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
                            uloge=db.Uloge.Where(a=>a.Uloge_ID==(db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["korisnik"] = k_final;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Unos()
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            List<Uloge> lista_uloge = db.Uloge.Where(a=>a.Uloge_ID!=1).Select(x => new Uloge
            {
                Naziv = x.Naziv,
                Opis = x.Opis,
                Sifra = x.Sifra,
                Uloge_ID = x.Uloge_ID
            }).ToList();

            ViewData["uloge"] = lista_uloge;

            List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();
            ViewData["organizacione_jedinice"] = org_jed_lista;

            return View("Unos");
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int uloga, int sifra, string ime, string prezime, string telefon, string mail, string lozinka, string username, int Org_jed_id)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            Korisnici temp = new Korisnici
            {
                Ime = ime,
                Sifra = sifra,
                Lozinka = lozinka,
                Mail = mail,
                Prezime = prezime,
                Telefon = telefon,
                Uloge_FK = uloga,
                Korisnicko_Ime = username
            };

            db.Korisnici.Add(temp);
            db.SaveChanges();

            Korisnici_OrganizacionaJedinica tmp = new Korisnici_OrganizacionaJedinica
            {
                Korisnici_FK = db.Korisnici.Where(a=>a.Korisnicko_Ime==username).Select(o=>o.Korisnici_ID).FirstOrDefault(),
                OrganizacionaJedinica_FK = Org_jed_id
            };

            db.Korisnici_OrganizacionaJedinica.Add(tmp);
            db.SaveChanges();

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici> k_final = new List<Korisnici>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_final.Add(new Korisnici
                        {
                            Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
                            Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
                            Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
                            Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
                            Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
                            Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
                            Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
                            Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
                            Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
                            uloge = db.Uloge.Where(a => a.Uloge_ID == (db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["korisnik"] = k_final;

            return View("Prikaz");
        }
        [Area("AdminOrg")]
        public IActionResult Ukloni(int id)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            Korisnici tmp = db.Korisnici.Where(x => x.Korisnici_ID == id).SingleOrDefault();

            if (tmp != null)
            {
                db.Korisnici.Remove(tmp);
                db.SaveChanges();
            }

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici> k_final = new List<Korisnici>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_final.Add(new Korisnici
                        {
                            Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
                            Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
                            Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
                            Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
                            Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
                            Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
                            Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
                            Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
                            Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
                            uloge = db.Uloge.Where(a => a.Uloge_ID == (db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["korisnik"] = k_final;

            return View("Prikaz");
        }

        [Area("AdminOrg")]
        public IActionResult Uredi(int id)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            Korisnici k = db.Korisnici.Where(a => a.Korisnici_ID == id).FirstOrDefault();
            k.uloge = db.Uloge.Where(a => a.Uloge_ID == k.Uloge_FK).FirstOrDefault();
            ViewData["korisnik"] = k;

            List<Uloge> lista_uloge = db.Uloge.Where(a => a.Uloge_ID != 1).Select(x => new Uloge
            {
                Naziv = x.Naziv,
                Opis = x.Opis,
                Sifra = x.Sifra,
                Uloge_ID = x.Uloge_ID
            }).ToList();

            ViewData["uloge"] = lista_uloge;

            return View();
        }

        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int id, string ime, string korisnicko_ime, string lozinka, string mail, string prezime, int sifra, string telefon, int uloga)
        {
            ViewData["logo"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Logo).FirstOrDefault();

            Korisnici k = db.Korisnici.Where(a => a.Korisnici_ID == id).FirstOrDefault();

            k.Ime = ime;
            k.Korisnicko_Ime = korisnicko_ime;
            k.Lozinka = lozinka;
            k.Mail = mail;
            k.Prezime = prezime;
            k.Sifra = sifra;
            k.Telefon = telefon;
            k.Uloge_FK = uloga;

            db.SaveChanges();

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == (int)HttpContext.Session.GetInt32("organisation ID")).ToList();

            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici> k_final = new List<Korisnici>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed_temp)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_final.Add(new Korisnici
                        {
                            Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime).FirstOrDefault(),
                            Prezime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Prezime).FirstOrDefault(),
                            Korisnicko_Ime = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnicko_Ime).FirstOrDefault(),
                            Lozinka = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Lozinka).FirstOrDefault(),
                            Mail = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Mail).FirstOrDefault(),
                            Sifra = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Sifra).FirstOrDefault(),
                            Telefon = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Telefon).FirstOrDefault(),
                            Korisnici_ID = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Korisnici_ID).FirstOrDefault(),
                            Uloge_FK = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault(),
                            uloge = db.Uloge.Where(a => a.Uloge_ID == (db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Uloge_FK).FirstOrDefault())).FirstOrDefault()
                        });
                    }
                }
            }

            ViewData["korisnik"] = k_final;

            return View("Prikaz");
        }
    }
}