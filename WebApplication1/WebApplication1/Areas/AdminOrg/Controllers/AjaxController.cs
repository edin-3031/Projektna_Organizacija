using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Areas.AdminOrg.Controllers
{
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext db;
        string poruka = "Morate se ponovo prijaviti";

        public AjaxController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [Area("AdminOrg")]
        public IActionResult DetaljiRealizacija(int idAktivnost, int idProjekat, int idRealizacija, int korisnikId)
        {
            if (HttpContext.Session.GetInt32("user ID") == null)
            {
                TempData["poruka"] = poruka;
                return Redirect("/Auth/Index");
            }
            else
            {
                List<ProjekatAktivnostRealizacijaVM> lista_realizacije = db.ProjekatAktivnostRealizacija.Include(a => a.korisnici).Include(a => a.projekatAktivnostPlan).Include(a => a.projekatAktivnostPlan.projekatPlan).Include(a => a.projekatAktivnostPlan.projekatPlan.organizacionaJedinica).Include(a => a.projekatAktivnostPlan.projekatPlan.status).Select(x => new ProjekatAktivnostRealizacijaVM
                {
                    Datum = x.Datum,
                    Kolicina = x.Kolicina,
                    Korisnici_id = x.korisnici.Korisnici_ID,
                    Korisnici_naziv = x.korisnici.Ime.ToString() + " " + x.korisnici.Prezime.ToString(),
                    Opis = x.Opis,
                    OrgJed_id = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.OrganizacionaJedinica_ID,
                    OrgJed_naziv = x.projekatAktivnostPlan.projekatPlan.organizacionaJedinica.Naziv,
                    ProjekatAktivnostPlan_id = x.projekatAktivnostPlan.ProjekatAktivnostPlan_ID,
                    ProjekatAktivnostPlan_naziv = x.projekatAktivnostPlan.Naziv,
                    ProjekatAktivnostRealizacija_ID = x.ProjekatAktivnostRealizacija_ID,
                    ProjekatPlan_id = x.projekatAktivnostPlan.projekatPlan.ProjekatPlan_ID,
                    ProjekatPlan_naziv = x.projekatAktivnostPlan.projekatPlan.Naziv
                }).ToList();

                List<DetaljiRealizacijaVM> _lista = new List<DetaljiRealizacijaVM>();


                foreach (var x in lista_realizacije)
                {
                    if (x.ProjekatAktivnostPlan_id == idAktivnost)
                    {

                        _lista.Add(new DetaljiRealizacijaVM
                        {
                            datum = x.Datum,
                            idAktivnost = x.ProjekatAktivnostPlan_id,
                            idProjekat = x.ProjekatPlan_id,
                            idRealizacija = x.ProjekatAktivnostRealizacija_ID,
                            idUser = x.Korisnici_id,
                            kolicina = x.Kolicina,
                            korisnik = x.Korisnici_naziv,
                            NazivAktivnosti = x.ProjekatAktivnostPlan_naziv,
                            NazivProjekta = x.ProjekatPlan_naziv,
                            opis = x.Opis,
                            organizacionaJedinica = x.OrgJed_naziv
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
}