using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luisde_Prestamos_Cd.models
{
    public class Sancion
    {
        public int Id { get; set; }
        public int noSancion { get; set; }
        public int codigoCliente { get; set; }
        public int noAlquiler { get; set; }
        public string tipoSancion { get; set; }
        public int noDiasSancion { get; set; }
    }
}
