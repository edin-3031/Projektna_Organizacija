﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PTT
    {
        [Key]
        public int PTT_ID { get; set; }

        public int Sifra { get; set; }
        public string Naziv { get; set; }
    }
}
