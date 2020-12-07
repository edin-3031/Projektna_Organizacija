using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Korisnici
    {
        [Key]
        public int Korisnici_ID { get; set; }

        public Uloge uloge { get; set; }
        [ForeignKey("uloge")]
        public int Uloge_FK { get; set; }

        public int Sifra { get; set; }
        public string Korisnicko_Ime{ get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Lozinka { get; set; }
    }
}
