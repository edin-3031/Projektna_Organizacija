﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.User.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext db;

        public UserController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Area("User")]
        public IActionResult Index(int u, int o, int r)
        {
            uor podaci = new uor
            {
                roleId=r,
                organisationId=o,
                userId=u
            };

            ViewData["id"] = podaci;

            ViewData["slika"] = db.Organizacija.Where(a => a.Organizacija_ID == o).Select(o => o.Slika).FirstOrDefault();

            return View(podaci);
        }
    }
}
