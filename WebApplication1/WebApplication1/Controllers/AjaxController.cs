using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext db;

        public AjaxController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult DetaljiRealizacija(int idRealizacija, int idProjekat)
        {
            DetaljiRealizacijaVM model = new DetaljiRealizacijaVM
            {
                idProjekat = idProjekat,
                idRealizacija = idRealizacija,
                datum = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Datum.Date).FirstOrDefault(),
                idUser = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Korisnici_FK).FirstOrDefault(),
                kolicina = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Kolicina).FirstOrDefault(),
                opis = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Opis).FirstOrDefault()
            };
            model.korisnik = db.Korisnici.Where(y => y.Korisnici_ID == model.idUser).Select(o => o.Ime + " " + o.Prezime).FirstOrDefault();
            model.NazivProjekta = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == idProjekat).Select(o => o.Naziv).FirstOrDefault();

            return PartialView(model);
        }
    }
}
