using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using Microsoft.AspNetCore.Http;


namespace WebApplication1.Areas.UserReport.Controllers
{
    public class UserReportController : Controller
    {
        private readonly ApplicationDbContext db;

        public UserReportController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("UserReport")]
        public IActionResult Index()
        {
            ViewData["slika"] = db.Organizacija.Where(a => a.Organizacija_ID == (int)HttpContext.Session.GetInt32("organisation ID")).Select(o => o.Slika).FirstOrDefault();

            return View();
        }

        [Area("UserReport")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return Redirect("/Auth/Index");
        }
    }
}