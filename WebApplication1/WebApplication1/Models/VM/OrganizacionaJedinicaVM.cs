using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class OrganizacionaJedinicaVM
    {
        public int OrganizacionaJedinica_ID { get; set; }

        public int Organizacija_id { get; set; }
        public string Organizacija_naziv { get; set; }

        public int PTT_id { get; set; }
        public string PTT_naziv { get; set; }

        public int Drzava_id { get; set; }
        public string Drzava_naziv { get; set; }

        public string Naziv { get; set; }

        public string Adresa { get; set; }
    }
}
