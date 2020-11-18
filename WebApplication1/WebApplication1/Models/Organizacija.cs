using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Organizacija
    {
        [Key]
        public int Organizacija_ID { get; set; }

        public PTT? ptt { get; set; }
        [ForeignKey("ptt")]
        public int PTT_FK { get; set; }

        public Drzava? drzava { get; set; }
        [ForeignKey("drzava")]
        public int Drzava_FK { get; set; }

        public int Sifra { get; set; }

        public string Naziv { get; set; }
        
        public string Adresa{ get; set; }

        public byte[] Slika { get; set; }

        public byte[] Logo { get; set; }
    }
}
