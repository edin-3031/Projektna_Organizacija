using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OrganizacionaJedinica
    {
        [Key]
        public int OrganizacionaJedinica_ID { get; set; }

        public Organizacija? organizacija { get; set; }
        [ForeignKey("organizacija")]
        public int Organizacija_FK { get; set; }

        public PTT? ptt{ get; set; }
        [ForeignKey("ptt")]
        public int PTT_FK{ get; set; }

        public Drzava? drzava{ get; set; }
        [ForeignKey("drzava")]
        public int Drzava_FK { get; set; }

        public string Naziv { get; set; }

        public string Adresa { get; set; }
    }
}
