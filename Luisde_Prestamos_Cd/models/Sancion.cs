﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luisde_Prestamos_Cd.models
{
    public class Sancion
    {
        public int Id { get; set; }
        public int NoSancion { get; set; }
        public string TipoSancion { get; set; }
        public int NoDiasSancion { get; set; } 
        public int AlquilerId { get; set; }
        public Alquiler Alquiler { get; set; }
    }
}
