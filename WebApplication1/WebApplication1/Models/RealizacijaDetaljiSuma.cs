using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RealizacijaDetaljiSuma
    {
        public int ProjekatId { get; set; }
        public string naziv_projekta { get; set; }
        public float planirano { get; set; }
        public float ostvareno { get; set; }
        public float procenti { get; set; }
        public int organizacionaJedinicaId { get; set; }
        public string organizacionaJedinica { get; set; }
    }
}
