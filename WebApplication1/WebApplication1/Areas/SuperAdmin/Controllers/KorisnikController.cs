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
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka = "Morate se ponovo prijaviti";


        public KorisnikController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Excel()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {

                List<Korisnici> korisnik = db.Korisnici.ToList();

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

                    foreach (var x in korisnik)
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
        }

        [Area("SuperAdmin")]
        public IActionResult Prikaz()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {

                List<Korisnici> lista_korisnici = db.Korisnici.ToList();

                foreach (var x in lista_korisnici)
                {
                    x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
                };

                ViewData["korisnik"] = lista_korisnici;

                return View("Prikaz");
            }
        }
        [Area("SuperAdmin")]
        public IActionResult Unos(bool? postoji=null, int?uloga=null, int? sifra=null, string? ime = null, string? prezime = null, string? telefon = null, string? mail = null, string? lozinka = null, string? username = null)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<Uloge> lista_uloge = db.Uloge.Select(x => new Uloge
                {
                    Naziv = x.Naziv,
                    Opis = x.Opis,
                    Sifra = x.Sifra,
                    Uloge_ID = x.Uloge_ID
                }).ToList();

                ViewData["uloge"] = lista_uloge;

                KorisniciVM model = new KorisniciVM
                {
                    Ime=ime,
                    Korisnicko_Ime=username,
                    Lozinka=lozinka,
                    Mail=mail,
                    Postoji=postoji,
                    Prezime=prezime,
                    Sifra=sifra,
                    Telefon=telefon,
                    Uloge_FK=uloga,
                    Uloge=db.Uloge.Where(a=>a.Uloge_ID==uloga).FirstOrDefault()
                };

                return View("Unos", model);
            }
        }
        [Area("SuperAdmin")]
        public IActionResult UnosSnimi(int uloga, int sifra, string ime, string prezime, string telefon, string mail, string lozinka, string username)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<KorisniciVM> list_test = db.Korisnici.Select(x => new KorisniciVM
                {
                    Korisnicko_Ime = x.Korisnicko_Ime
                }).ToList();
                
                bool postoji = false;
                
                foreach(var x in list_test)
                {
                    if (x.Korisnicko_Ime == username)
                    {
                        postoji = true;
                        break;
                    }
                }

                if (postoji)
                {
                    return Redirect("/SuperAdmin/Korisnik/Unos?postoji=" + postoji + "&uloga=" + uloga + "&sifra=" + sifra + "&ime=" + ime + "&prezime=" + prezime + "&telefon=" + telefon + "&mail=" + telefon + "&mail=" + mail + "&lozinka=" + lozinka + "&username=" + username);
                }
                else
                {
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

                }

                List<Korisnici> lista_korisnici = db.Korisnici.ToList();

                foreach (var x in lista_korisnici)
                {
                    x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
                };



                ViewData["korisnik"] = lista_korisnici;

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
            else
            {
                Korisnici tmp = db.Korisnici.Where(x => x.Korisnici_ID == id).SingleOrDefault();

                if (tmp != null)
                {
                    db.Korisnici.Remove(tmp);
                    db.SaveChanges();
                }



                List<Korisnici> lista_korisnici = db.Korisnici.ToList();

                foreach (var x in lista_korisnici)
                {
                    x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
                };



                ViewData["korisnik"] = lista_korisnici;
                return View("Prikaz");
            }
        }

        [Area("SuperAdmin")]
        public IActionResult Uredi(int id, bool postoji=false)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                Korisnici k = db.Korisnici.Where(a => a.Korisnici_ID == id).FirstOrDefault();
                k.uloge = db.Uloge.Where(a => a.Uloge_ID == k.Uloge_FK).FirstOrDefault();
                ViewData["korisnik"] = k;

                List<Uloge> uloge = db.Uloge.ToList();
                ViewData["uloge"] = uloge;

                ViewData["postoji"] = postoji;

                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult UrediSnimi(int id, string ime, string korisnicko_ime, string lozinka, string mail, string prezime, int sifra, string telefon, int uloga)
        {
            bool postoji = false;

            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<KorisniciVM> t = db.Korisnici.Select(a => new KorisniciVM
                {
                    Korisnicko_Ime=a.Korisnicko_Ime
                }).ToList();

                foreach(var x in t)
                {
                    if (x.Korisnicko_Ime == korisnicko_ime)
                    {
                        postoji = true;
                        break;
                    }
                }
                if (postoji)
                {
                    Korisnici temp = new Korisnici
                    {
                        Ime = ime,
                        Korisnici_ID = id,
                        Korisnicko_Ime = korisnicko_ime,
                        Lozinka = lozinka,
                        Mail = mail,
                        Prezime = prezime,
                        Sifra = sifra,
                        Telefon = telefon,
                        Uloge_FK = uloga,
                        uloge = db.Uloge.Where(a => a.Uloge_ID == uloga).FirstOrDefault()
                    };
                    ViewData["korisnik"] = temp;

                    ViewData["uloge"] = db.Uloge.ToList();

                    ViewData["postoji"] = postoji;

                    return Redirect("/SuperAdmin/Korisnik/Uredi?id="+id+"&postoji="+postoji);
                }
                else if (!postoji)
                {
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


                    List<Korisnici> lista_korisnici = db.Korisnici.ToList();

                    foreach (var x in lista_korisnici)
                    {
                        x.uloge = db.Uloge.Where(a => a.Uloge_ID == x.Uloge_FK).FirstOrDefault();
                    };

                    ViewData["korisnik"] = lista_korisnici;

                    return View("Prikaz");
                }
                return View("Error");
            }
        }
    }
}