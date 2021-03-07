using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luisde_Prestamos_Cd.models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
      public DbSet<Cliente> cliente { get; set;}
      public DbSet<Sancion> sancion { get; set; }
      public DbSet<Alquiler> alquiler { get; set;}
      public DbSet<DetalleAlquiler> detalleAlquiler { get; set; }
      public DbSet<Cd> cd { get; set; }

    }
}
