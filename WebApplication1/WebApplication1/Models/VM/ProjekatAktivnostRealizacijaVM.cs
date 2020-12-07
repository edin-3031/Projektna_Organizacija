using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class ProjekatAktivnostRealizacijaVM
    {
        public int ProjekatAktivnostRealizacija_ID { get; set; }


        public int ProjekatAktivnostPlan_id { get; set; }
        public string ProjekatAktivnostPlan_naziv { get; set; }

        public int ProjekatPlan_id { get; set; }
        public string ProjekatPlan_naziv { get; set; }

        public int Korisnici_id { get; set; }
        public string Korisnici_naziv { get; set; }

        public int OrgJed_id { get; set; }
        public string OrgJed_naziv { get; set; }

        public DateTime Datum { get; set; }
        public float Kolicina { get; set; }
        public string Opis { get; set; }
    }
}
