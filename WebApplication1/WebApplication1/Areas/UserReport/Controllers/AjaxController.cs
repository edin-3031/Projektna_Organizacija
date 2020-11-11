using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.UserReport.Controllers
{
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext db;

        public AjaxController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("UserReport")]
        public IActionResult DetaljiRealizacija(int idAktivnost, int idProjekat, int idRealizacija, int korisnikId)
            {
            List<ProjekatAktivnostRealizacija> lista_realizacije = db.ProjekatAktivnostRealizacija.ToList();

            List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();


            foreach (var x in lista_realizacije)
            {
                if(x.ProjekatAktivnostPlan_FK==idAktivnost)
                {
                    int _user = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Korisnici_FK).FirstOrDefault();
                    _lista.Add(new DetaljiRealizacijaVM
                    {
                        datum=x.Datum.Date,
                        idAktivnost=idAktivnost,
                        idProjekat=idProjekat,
                        idRealizacija=idRealizacija,
                        idUser=korisnikId,
                        kolicina=x.Kolicina,
                        korisnik=db.Korisnici.Where(a=>a.Korisnici_ID== _user).Select(o=>o.Ime.ToString()+" "+o.Prezime.ToString()).FirstOrDefault(),
                        NazivAktivnosti=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==idAktivnost).Select(o=>o.Naziv).FirstOrDefault(),
                        NazivProjekta=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==idProjekat).Select(o=>o.Naziv).FirstOrDefault(),
                        opis=x.Opis
                    });
                }
            }

            lista_DetaljiRealizacijaVM model = new lista_DetaljiRealizacijaVM
            {
                lista = _lista
            };

            return PartialView(model);
        }
    }
}
