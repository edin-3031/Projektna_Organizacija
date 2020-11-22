﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
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

namespace WebApplication1.Areas.AdminOrg.Controllers
{
    public class KorisnikOrgController : Controller
    {
        private readonly ApplicationDbContext db;
        public KorisnikOrgController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("AdminOrg")]
        public IActionResult Excel(int o)
        {

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_final = new List<Korisnici_OrganizacionaJedinica>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_o_final.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK = x.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["kor_org_jed"] = k_o_final;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Korisnik_organizacionaJedinica");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Korisnici-Organizaciona jedinica ID";
                worksheet.Cell(currentRow, 2).Value = "Korisnik";
                worksheet.Cell(currentRow, 3).Value = "Organizaciona jedinica";

                foreach (var x in k_o_final)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = x.Korisnici_OrganizacionaJedinica_ID;
                    worksheet.Cell(currentRow, 2).Value = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).Select(o => o.Ime.ToString() + " " + o.Prezime.ToString()).FirstOrDefault();
                    worksheet.Cell(currentRow, 3).Value = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).Select(o => o.Naziv.ToString()).FirstOrDefault();
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Korisnici-OrganizacionaJedinicaInfo_" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + ".xlsx");
                }
            }
        }

        [Area("AdminOrg")]
        public IActionResult Prikaz(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_final = new List<Korisnici_OrganizacionaJedinica>();

            foreach(var x in k_o_temp)
            {
                foreach(var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_o_final.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK=x.Korisnici_FK,
                            korisnici=db.Korisnici.Where(a=>a.Korisnici_ID==x.Korisnici_FK).FirstOrDefault(),
                            Korisnici_OrganizacionaJedinica_ID=x.Korisnici_OrganizacionaJedinica_ID,
                            OrganizacionaJedinica_FK=x.OrganizacionaJedinica_FK,
                            organizacionaJedinica=db.OrganizacionaJedinica.Where(a=>a.OrganizacionaJedinica_ID==x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["kor_org_jed"] = k_o_final;
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
        public IActionResult Unos(int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

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

            List<OrganizacionaJedinica> lista_org_jed = db.OrganizacionaJedinica.Where(a=>a.Organizacija_FK==o).Select(x => new OrganizacionaJedinica
            {
                OrganizacionaJedinica_ID=x.OrganizacionaJedinica_ID,
                Naziv=x.Naziv,
            }).ToList();

            ViewData["org_jed"] = lista_org_jed;

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
        public IActionResult UnosSnimi(int korisnik, int organizacionaJedinica, int u, int o, int r)
        {

            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;
            Korisnici_OrganizacionaJedinica temp = new Korisnici_OrganizacionaJedinica
            {
                Korisnici_FK = korisnik,
                OrganizacionaJedinica_FK = organizacionaJedinica
            };

            db.Korisnici_OrganizacionaJedinica.Add(temp);
            db.SaveChanges();


            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_final = new List<Korisnici_OrganizacionaJedinica>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_o_final.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK = x.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["kor_org_jed"] = k_o_final;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
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

            Korisnici_OrganizacionaJedinica temp = db.Korisnici_OrganizacionaJedinica.Where(a => a.Korisnici_OrganizacionaJedinica_ID == id).FirstOrDefault();
            temp.korisnici = db.Korisnici.Where(a => a.Korisnici_ID == temp.Korisnici_FK).FirstOrDefault();
            temp.organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == temp.OrganizacionaJedinica_FK).FirstOrDefault();
            ViewData["kor_oj"] = temp;

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a=>a.Organizacija_FK==o).ToList();
            ViewData["OrganizacionaJedinice"] = org_jed;

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
        public IActionResult UrediSnimi(int k_o_id, int u, int o, int r, int korisnik, int org_jed)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            Korisnici_OrganizacionaJedinica t = db.Korisnici_OrganizacionaJedinica.Where(a => a.Korisnici_OrganizacionaJedinica_ID == k_o_id).FirstOrDefault();

            t.Korisnici_FK = korisnik;
            t.OrganizacionaJedinica_FK = org_jed;

            db.SaveChanges();


            List<OrganizacionaJedinica> org_jed_2 = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_final = new List<Korisnici_OrganizacionaJedinica>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed_2)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_o_final.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK = x.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["kor_org_jed"] = k_o_final;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }

        [Area("AdminOrg")]
        public IActionResult Ukloni(int id, int u, int o, int r)
        {
            byte[] logo = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Logo).FirstOrDefault();

            ViewData["logo"] = logo;

            Korisnici_OrganizacionaJedinica temp = db.Korisnici_OrganizacionaJedinica.Where(v => v.Korisnici_OrganizacionaJedinica_ID == id).SingleOrDefault();

            if (temp != null)
            {
                db.Korisnici_OrganizacionaJedinica.Remove(temp);
                db.SaveChanges();
            }

            List<OrganizacionaJedinica> org_jed = db.OrganizacionaJedinica.Where(a => a.Organizacija_FK == o).ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_temp = db.Korisnici_OrganizacionaJedinica.ToList();
            List<Korisnici_OrganizacionaJedinica> k_o_final = new List<Korisnici_OrganizacionaJedinica>();

            foreach (var x in k_o_temp)
            {
                foreach (var y in org_jed)
                {
                    if (x.OrganizacionaJedinica_FK == y.OrganizacionaJedinica_ID)
                    {
                        k_o_final.Add(new Korisnici_OrganizacionaJedinica
                        {
                            Korisnici_FK = x.Korisnici_FK,
                            korisnici = db.Korisnici.Where(a => a.Korisnici_ID == x.Korisnici_FK).FirstOrDefault(),
                            Korisnici_OrganizacionaJedinica_ID = x.Korisnici_OrganizacionaJedinica_ID,
                            OrganizacionaJedinica_FK = x.OrganizacionaJedinica_FK,
                            organizacionaJedinica = db.OrganizacionaJedinica.Where(a => a.OrganizacionaJedinica_ID == x.OrganizacionaJedinica_FK).FirstOrDefault()
                        });
                    }
                }
            }
            ViewData["kor_org_jed"] = k_o_final;

            uor podaci = new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            ViewData["id"] = podaci;

            return View("Prikaz");
        }
    }
}