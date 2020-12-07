using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class ProjekatAktivnostPlanVM
    {
        public int ProjekatAktivnostPlan_ID { get; set; }

        public int ProjekatPlan_id { get; set; }
        public string ProjekatPlan_naziv { get; set; }

        public int Sifra { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string JedinicaMjere { get; set; }
        public float Kolicina { get; set; }
    }
}
