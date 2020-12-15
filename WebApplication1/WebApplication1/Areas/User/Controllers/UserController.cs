using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.User.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext db;
        string poruka = "Morate se ponovo prijaviti";
        string poruka2 = "Nemate pravo pristupa";

        public UserController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("User")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }

            if (HttpContext.Session.GetString("role") != "User")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                ViewData["slika"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Slika).FirstOrDefault();

                return View();
            }
        }

        [Area("User")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return Redirect("/Auth/Index");
        }
    }
}
