using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProjekatAktivnostRealizacija
    {
        [Key]
        public int ProjekatAktivnostRealizacija_ID { get; set; }
        
        public ProjekatAktivnostPlan? projekatAktivnostPlan { get; set; }
        [ForeignKey("projekatAktivnostPlan")]
        public int ProjekatAktivnostPlan_FK { get; set; }

        public Korisnici? korisnici { get; set; }
        [ForeignKey("korisnici ")]
        public int Korisnici_FK { get; set; }

        public DateTime Datum { get; set; }
        public float Kolicina { get; set; }
        public string Opis { get; set; }
    }
}
