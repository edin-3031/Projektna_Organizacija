using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Tls;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using HashAlgorithm = System.Security.Cryptography.HashAlgorithm;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {

        private readonly ApplicationDbContext db;

        public AuthController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthProces(string username, string pass)
        {
            LogInVM log = db.Korisnici_OrganizacionaJedinica.Include(a => a.korisnici).Include(a => a.organizacionaJedinica).Include(a => a.organizacionaJedinica.organizacija).Where(a => a.korisnici.Korisnicko_Ime == username && a.korisnici.Lozinka == pass).Include(a => a.korisnici.uloge).Select(x => new LogInVM
            {
                organisation = x.organizacionaJedinica.organizacija.Naziv,
                organisationId = x.organizacionaJedinica.organizacija.Organizacija_ID,
                orgJed = x.organizacionaJedinica.Naziv,
                orgJedId = x.organizacionaJedinica.OrganizacionaJedinica_ID,
                password = x.korisnici.Lozinka,
                role = x.korisnici.uloge.Naziv,
                roleId = x.korisnici.uloge.Uloge_ID,
                user = x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString(),
                userId = x.korisnici.Korisnici_ID,
                username = x.korisnici.Korisnicko_Ime
            }).FirstOrDefault();

            if (log == null)
            {
                string msg = "Niste unijeli ispravne podatke";
                TempData["poruka"] = msg;
            }
            else
            {
                HttpContext.Session.SetString("organisation", log.organisation);
                HttpContext.Session.SetInt32("organisation ID", log.organisationId.Value);
                HttpContext.Session.SetString("orgJed", log.orgJed);
                HttpContext.Session.SetInt32("orgJed ID", log.orgJedId.Value);
                HttpContext.Session.SetString("role", log.role);
                HttpContext.Session.SetInt32("role ID", log.roleId.Value);
                HttpContext.Session.SetString("user", log.user);
                HttpContext.Session.SetInt32("user ID", log.userId.Value);
                HttpContext.Session.SetString("username", log.username);

                switch (log.role)
                {
                    case "SuperAdmin": return Redirect("/SuperAdmin/SuperAdmin/Index");/*break;*/
                    case "Admin-Org": return Redirect("/AdminOrg/AdminOrg/Index"); /*break;*/
                    case "User": return Redirect("/User/User/Index"); /*break;*/
                    case "User-Report": return Redirect("/UserReport/UserReport/Index"); /*break;*/
                    case "Admin-Org-Jed": return Redirect("/AdminOrgJed/AdminOrgJed/Index"); /*break;*/
                }
            }
         
            return Redirect("/Auth/index");
        }
    }
}