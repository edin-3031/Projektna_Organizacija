using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class OrganizacijaVM
    {
        public int Organizacija_ID { get; set; }

        public int PTT_id { get; set; }
        public string PTT_naziv { get; set; }

        public int Drzava_id { get; set; }
        public string Drzava_naziv { get; set; }

        public int Sifra { get; set; }

        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public byte[] Slika { get; set; }

        public byte[] Logo { get; set; }
    }
}
