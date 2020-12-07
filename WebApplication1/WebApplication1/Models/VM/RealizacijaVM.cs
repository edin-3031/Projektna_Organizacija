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
        public int aktivnostId { get; set; }
        public string naziv_aktivnosti { get; set; }
        public string nazivProjekta { get; set; }
        public DateTime datum { get; set; }
        public float planirano { get; set; }
        public float odradjeno { get; set; }
        public int korisnikId { get; set; }
    }

    public class lista_realizacijaVM
    {
        #nullable enable
        public List<RealizacijaVM>? liste { get; set; }
        public int? projekat_Id { get; set; }
        public int organizacijaId { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
    }
}