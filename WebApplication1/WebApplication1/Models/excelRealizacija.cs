using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class excelRealizacija
    {
        public string projekat_naziv { get; set; }
        public string aktivnost_naziv { get; set; }
        public string korisnik_ime{ get; set; }
        public DateTime datum{ get; set; }
        public float kolicina{ get; set; }
        public string opis{ get; set; }
    }
}
