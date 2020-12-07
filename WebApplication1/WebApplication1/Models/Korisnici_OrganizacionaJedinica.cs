using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Korisnici_OrganizacionaJedinica
    {
        [Key]
        public int Korisnici_OrganizacionaJedinica_ID { get; set; }

        public Korisnici korisnici { get; set; }
        [ForeignKey("korisnici")]
        public int Korisnici_FK { get; set; }

        public OrganizacionaJedinica organizacionaJedinica { get; set; }
        [ForeignKey("organizacionaJedinica")]
        public int OrganizacionaJedinica_FK { get; set; }
    }
}
