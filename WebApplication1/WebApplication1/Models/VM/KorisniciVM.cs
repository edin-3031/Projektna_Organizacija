using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class KorisniciVM
    {
        public int? Uloge_FK { get; set; }
        public Uloge? Uloge { get; set; }
        public bool? Postoji { get; set; }
        public int? Sifra { get; set; }
        public string? Korisnicko_Ime { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Telefon { get; set; }
        public string? Mail { get; set; }
        public string? Lozinka { get; set; }
    }
}
