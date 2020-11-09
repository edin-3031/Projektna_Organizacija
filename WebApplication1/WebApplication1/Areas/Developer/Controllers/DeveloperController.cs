using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Areas.Developer.Controllers
{

    public class DeveloperController : Controller
    {
        private readonly ApplicationDbContext db;

        public DeveloperController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("Developer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
