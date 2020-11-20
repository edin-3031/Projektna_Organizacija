using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.SuperAdmin.Controllers
{
    public class SuperAdminController : Controller
    {
        private readonly ApplicationDbContext db;

        public SuperAdminController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("SuperAdmin")]
        public IActionResult Index(int u, int o, int r)
        {
            uor model= new uor
            {
                organisationId = o,
                roleId = r,
                userId = u
            };

            return View(model);
        }
    }
}