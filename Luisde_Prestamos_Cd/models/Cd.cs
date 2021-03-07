using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luisde_Prestamos_Cd.models
{
    public class Cd
    {
        public int Id { get; set; }
        public int codigoTitulo { get; set; }
        public int noCd { get; set; }
        public string condicion { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }
}
