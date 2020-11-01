using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class RealizacijaVM
    {
        public int projekatId { get; set; }
        public int realizacijaId { get; set; }
        public string nazivProjekta { get; set; }
        public DateTime datum { get; set; }
        public float planirano { get; set; }
        public float odradjeno { get; set; }
    }

    public class lista_realizacijaVM
    {
        public List<RealizacijaVM>? liste { get; set; }
    }
}