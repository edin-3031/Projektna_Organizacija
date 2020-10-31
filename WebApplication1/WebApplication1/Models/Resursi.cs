using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Resursi
    {
        [Key]
        public int Resursi_ID { get; set; }

        public string Naziv{ get; set; }
    }
}
