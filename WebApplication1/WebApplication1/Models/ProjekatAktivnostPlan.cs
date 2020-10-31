using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProjekatAktivnostPlan
    {
        [Key]
        public int ProjekatAktivnostPlan_ID { get; set; }

        public ProjekatPlan? projekatPlan { get; set; }
        [ForeignKey("projekatPlan ")]
        public int ProjekatPlan_FK{ get; set; }

        public int Sifra { get; set; }
        public string Naziv{ get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string JedinicaMjere { get; set; }
        public float Kolicina { get; set; }

    }
}
