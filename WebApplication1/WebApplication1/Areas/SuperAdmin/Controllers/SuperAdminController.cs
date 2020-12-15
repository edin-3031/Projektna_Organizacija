using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class SuperAdminController : Controller
    {
        private readonly ApplicationDbContext db;
        public string poruka1 = "Morate se ponovo prijaviti";
        public string poruka2 = "Nemate pravo pristupa";

        public SuperAdminController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka1;
                return Redirect("/Auth/Index");
            }
            if (HttpContext.Session.GetString("role") != "SuperAdmin")
            {
                TempData["poruka"] = poruka2;
                return Redirect("/Auth/Index");
            }
            else
            {
                return View();
            }
        }

        [Area("SuperAdmin")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return Redirect("/Auth/Index");
        }
    }
}