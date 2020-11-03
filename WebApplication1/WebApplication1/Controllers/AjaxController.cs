using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
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

        public IActionResult DetaljiRealizacija(int idAktivnost, int idProjekat, int idRealizacija, int korisnikId)
        {
            //List<ProjekatAktivnostRealizacija> real = db.ProjekatAktivnostRealizacija.Where(a=>a.ProjekatAktivnostPlan_FK==idAktivnost).Select(x => new ProjekatAktivnostRealizacija
            //{
            //    Datum=x.Datum,
            //    Kolicina=x.Kolicina,
            //    Korisnici_FK=x.Korisnici_FK,
            //    Opis=x.Opis,
            //    korisnici=x.korisnici,
            //    projekatAktivnostPlan=x.projekatAktivnostPlan,
            //    ProjekatAktivnostPlan_FK=x.ProjekatAktivnostPlan_FK,
            //    ProjekatAktivnostRealizacija_ID=x.ProjekatAktivnostRealizacija_ID
            //}).ToList();


            //foreach (var x in real)
            //{
            //    _lista.Add(new DetaljiRealizacijaVM
            //    {
            //        datum=x.Datum,
            //        kolicina=x.Kolicina,
            //        korisnik=db.Korisnici.Where(o=>o.Korisnici_ID==korisnikId).Select(a=>a.Ime+" "+a.Prezime).FirstOrDefault(),
            //        NazivAktivnosti=db.ProjekatAktivnostPlan.Where(a=>a.ProjekatAktivnostPlan_ID==idAktivnost).Select(o=>o.Naziv).FirstOrDefault(),
            //        opis=x.Opis,
            //        NazivProjekta=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==idProjekat).Select(o=>o.Naziv).FirstOrDefault()
                    
            //    });
            //}

            //List<DetaljiRealizacijaVM> _lista = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(x => new DetaljiRealizacijaVM
            //{
            //    idProjekat = idProjekat,
            //    idRealizacija = idRealizacija,
            //    datum = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Datum.Date).FirstOrDefault(),
            //    idUser = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Korisnici_FK).FirstOrDefault(),
            //    kolicina = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Kolicina).FirstOrDefault(),
            //    opis = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Opis).FirstOrDefault(),
            //    idAktivnost = idAktivnost,
            //    NazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == idProjekat).Select(o => o.Naziv).FirstOrDefault(),
            //    NazivAktivnosti = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == idAktivnost).Select(o => o.Naziv).FirstOrDefault(),
            //    korisnik = db.Korisnici.Where(a => a.Korisnici_ID == korisnikId).Select(o => o.Ime + " " + o.Prezime).FirstOrDefault()
                
            //}).ToList();

            //DetaljiRealizacijaVM model = new DetaljiRealizacijaVM
            //{
            //    idProjekat = idProjekat,
            //    idRealizacija = idRealizacija,
            //    datum = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Datum.Date).FirstOrDefault(),
            //    idUser = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Korisnici_FK).FirstOrDefault(),
            //    kolicina = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Kolicina).FirstOrDefault(),
            //    opis = db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostRealizacija_ID == idRealizacija).Select(o => o.Opis).FirstOrDefault(),
            //    idAktivnost = idAktivnost,
            //    NazivProjekta = db.ProjekatPlan.Where(a => a.ProjekatPlan_ID == idProjekat).Select(o => o.Naziv).FirstOrDefault(),
            //    NazivAktivnosti = db.ProjekatAktivnostPlan.Where(a => a.ProjekatAktivnostPlan_ID == idAktivnost).Select(o => o.Naziv).FirstOrDefault(),
            //    korisnik=db.Korisnici.Where(a=>a.Korisnici_ID==korisnikId).Select(o=>o.Ime+" "+o.Prezime).FirstOrDefault()
            //};
            //model.korisnik = db.Korisnici.Where(y => y.Korisnici_ID == model.idUser).Select(o => o.Ime + " " + o.Prezime).FirstOrDefault();
            //model.NazivProjekta = db.ProjekatPlan.Where(x => x.ProjekatPlan_ID == idProjekat).Select(o => o.Naziv).FirstOrDefault();


            List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();

            List<ProjekatAktivnostPlan> lap = db.ProjekatAktivnostPlan.Where(a => a.ProjekatPlan_FK == idProjekat).Select(x => new ProjekatAktivnostPlan
            {
                DatumDo=x.DatumDo,
                ProjekatPlan_FK=x.ProjekatPlan_FK,
                DatumOd=x.DatumOd,
                JedinicaMjere=x.JedinicaMjere,
                Kolicina=x.Kolicina,
                ProjekatAktivnostPlan_ID=x.ProjekatAktivnostPlan_ID,
                Naziv=x.Naziv,
                Sifra=x.Sifra
            }).ToList();


            foreach(var t in lap)
            {
                _lista.Add(new DetaljiRealizacijaVM
                {
                    datum=db.ProjekatAktivnostRealizacija.Where(a=>a.ProjekatAktivnostPlan_FK==t.ProjekatAktivnostPlan_ID).Select(o=>o.Datum).FirstOrDefault(),
                    idAktivnost=t.ProjekatAktivnostPlan_ID,
                    idProjekat=idProjekat,
                    idRealizacija=idRealizacija,
                    kolicina=db.ProjekatAktivnostRealizacija.Where(a=>a.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o=>o.Kolicina).FirstOrDefault(),
                    opis= db.ProjekatAktivnostRealizacija.Where(a => a.ProjekatAktivnostPlan_FK == t.ProjekatAktivnostPlan_ID).Select(o => o.Opis).FirstOrDefault(),
                    NazivAktivnosti=t.Naziv,
                    NazivProjekta=db.ProjekatPlan.Where(a=>a.ProjekatPlan_ID==t.ProjekatPlan_FK).Select(a=>a.Naziv).FirstOrDefault(),
                    korisnik="Red"
                });
            }

            lista_DetaljiRealizacijaVM model = new lista_DetaljiRealizacijaVM
            {
                lista = _lista
            };


            return PartialView(model);
        }
    }
}
