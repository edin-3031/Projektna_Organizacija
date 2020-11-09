﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Tls;
using WebApplication1.Data;
using WebApplication1.Models;
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
            int? role = db.Korisnici.Where(a => a.Korisnicko_Ime == username && a.Lozinka == pass).Select(o => o.Uloge_FK).FirstOrDefault();

            var algo = HashAlgorithm.Create("sha1");

            if (role != 0)
            {
                //priprema za korištenje u svrhu provjere
                byte[] hash = algo.ComputeHash(Encoding.UTF8.GetBytes(role.ToString()));
                // hash spreman za provjeru
                string final = Convert.ToBase64String(hash);

                List<Uloge> uloge = db.Uloge.ToList();
                foreach (var x in uloge)
                {
                    //nova uloga
                    var temp = x.Uloge_ID.ToString();
                    //novi hash dobavljenje uloge
                    var new_hash = algo.ComputeHash(Encoding.UTF8.GetBytes(temp.ToString()));
                    string new_final = Convert.ToBase64String(new_hash);

                    if (final==new_final)
                    {
                        if (x.Uloge_ID == 1)
                            return Redirect("/Admin/Admin/Index");
                        else if (x.Uloge_ID == 2)
                            return Redirect("/User/User/Index");
                        else if (x.Uloge_ID == 3)
                            return Redirect("/Home/Error");
                    }
                }
            }
            return Redirect("/Home/Error");
        }
    }
}