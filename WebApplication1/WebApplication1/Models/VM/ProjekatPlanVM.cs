using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class ProjekatPlanVM
    {
        public int ProjekatPlan_ID { get; set; }

        public int OrganizacionaJedinica_id { get; set; }
        public string OrganizacionaJedinica_naziv { get; set; }

        public int Status_id { get; set; }
        public string Status_naziv { get; set; }

        public int Sifra { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }


    }
}
