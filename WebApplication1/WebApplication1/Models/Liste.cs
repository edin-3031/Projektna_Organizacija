using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Liste
    {
        public List<ProjekatPlan> Lista_projekata { get; set; }
        public List<ProjekatAktivnostPlan> Lista_aktiv_plan { get; set; }
        public List<ProjekatAktivnostRealizacija> Lista_aktiv_real { get; set; }
    }
}
