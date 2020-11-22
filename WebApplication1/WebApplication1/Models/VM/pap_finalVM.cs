using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class pap_finalVM
    {
        public int projekatPlan_fk { get; set; }
        public int projekatAktivnost_Id { get; set; }
        public OrganizacionaJedinica o_j_all { get; set; }
    }
}
