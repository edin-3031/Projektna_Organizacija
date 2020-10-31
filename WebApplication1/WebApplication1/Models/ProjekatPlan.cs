using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProjekatPlan
    {
        [Key]
        public int ProjekatPlan_ID {get;set;}

        public OrganizacionaJedinica? organizacionaJedinica { get; set; }
        [ForeignKey("organizacionaJedinica")]
        public int OrganizacionaJedinica_FK { get; set; }

        public int Sifra { get; set; }
        public string Naziv{ get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
    }
}
