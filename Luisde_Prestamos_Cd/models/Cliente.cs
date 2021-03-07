using System;

namespace Luisde_Prestamos_Cd.models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int codigoCliente { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int nroDNI { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaInscripcion { get; set; }
        public string temaInteres { get; set; }
        public bool estado { get; set; }
    }
}
