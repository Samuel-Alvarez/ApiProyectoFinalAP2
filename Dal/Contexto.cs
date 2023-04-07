using Aplicada2Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Aplicada2Api.Dal
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options): base(options){ }

        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Reportes> Reportes { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Solicitudes> Solicitudes { get; set; }
        public DbSet<Mecanicos> Mecanicos { get; set; }
    }
}
