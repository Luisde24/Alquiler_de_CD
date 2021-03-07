using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luisde_Prestamos_Cd.models
{
    public class DetalleAlquiler
    {
        public int Id { get; set; }
        public int noAlquiler { get; set; }
        public string item { get; set; }
        public int codigoTitulo { get; set; }
        public int noCd { get; set; }
        public string diasPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }

    }
}
