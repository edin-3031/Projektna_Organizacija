using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class par_final_VM
    {
        public int ProjekatAktivnostRealizacija_ID { get; set; }
        public int ProjekatAktivnostPlan_FK { get; set; }
        public ProjekatAktivnostPlan ProjekatAktivnostPlan_all { get; set; }
        public int Korisnici_FK { get; set; }
        public Korisnici Korisnici { get; set; }
        public string korisnik_ime{ get; set; }
        public DateTime Datum { get; set; }
        public float Kolicina { get; set; }
        public string Opis { get; set; }
        public OrganizacionaJedinica OrgJed { get; set; }
        public ProjekatPlan proj_plan{ get; set; }
    }
}
