using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.IO;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Asn1.Misc;
using Microsoft.AspNetCore.Hosting;
using SelectPdf;
using Aspose.Pdf;
using Microsoft.Data.SqlClient;


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
        public IActionResult Excel(int o)
        {

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

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
        public IActionResult Prikaz(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

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
        public IActionResult Unos(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            List<Uloge> lista_uloge = db.Uloge.Where(a=>a.Uloge_ID!=1).Select(x => new Uloge
            {
                Naziv = x.Naziv,
                Opis = x.Opis,
                Sifra = x.Sifra,
                Uloge_ID = x.Uloge_ID
            }).ToList();

            ViewData["uloge"] = lista_uloge;

            List<OrganizacionaJedinica> org_jed_lista = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            ViewData["organizacione_jedinice"] = org_jed_lista;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Unos");
        }
        [Area("AdminOrg")]
        public IActionResult UnosSnimi(int uloga, int sifra, string ime, string prezime, string telefon, string mail, string lozinka, string username, int u, int o, int r, int Org_jed_id)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
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

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };
            ViewData["id"] = podaci;

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

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
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            Korisnici tmp = db.Korisnici.Where(x => x.Korisnici_ID == id).SingleOrDefault();

            if (tmp != null)
            {
                db.Korisnici.Remove(tmp);
                db.SaveChanges();
            }

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };
            ViewData["id"] = podaci;

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

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
        public IActionResult Uredi(int id, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            Korisnici k = db.Korisnici.Where(a => a.Korisnici_ID == id).FirstOrDefault();
            k.uloge = db.Uloge.Where(a => a.Uloge_ID == k.Uloge_FK).FirstOrDefault();
            ViewData["korisnik"] = k;

            List<Uloge> uloge = db.Uloge.ToList();
            ViewData["uloge"] = uloge;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };
            ViewData["id"] = podaci;

            return View();
        }

        [Area("AdminOrg")]
        public IActionResult UrediSnimi(int id, int u, int o, int r, string ime, string korisnicko_ime, string lozinka, string mail, string prezime, int sifra, string telefon, int uloga)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
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

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            List<OrganizacionaJedinica> org_jed_temp = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();

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