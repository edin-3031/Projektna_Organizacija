using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class DetaljiRealizacijaVM
    {
        public int idProjekat { get; set; }
        public int idAktivnost { get; set; }
        public string NazivAktivnosti { get; set; }
        public string NazivProjekta { get; set; }
        public int idRealizacija { get; set; }
        public DateTime datum{ get; set; }
        public float kolicina{ get; set; }
        public int idUser{ get; set; }
        public string korisnik{ get; set; }
        public string opis{ get; set; }
        public string organizacionaJedinica { get; set; }
    }

    public class lista_DetaljiRealizacijaVM
    {
        public List<DetaljiRealizacijaVM>? lista { get; set; }
    }

}
