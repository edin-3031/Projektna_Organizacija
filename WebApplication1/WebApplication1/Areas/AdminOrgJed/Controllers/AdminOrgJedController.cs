using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.AdminOrgJed.Controllers
{
    public class AdminOrgJedController : Controller
    {
        private readonly ApplicationDbContext db;

        public AdminOrgJedController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("AdminOrgJed")]
        public IActionResult Index()
        {
            ViewData["slika"] = db.Organizacija.Where(a => a.Organizacija_ID == HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Slika).FirstOrDefault();

            return View();
        }

        [Area("AdminOrgJed")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return Redirect("/Auth/Index");
        }
    }
}