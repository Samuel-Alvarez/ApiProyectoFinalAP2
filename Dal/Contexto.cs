using Aplicada2Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Aplicada2Api.Dal
{
    public class Contexto : DbContext
    {

        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Reportes> Reportes { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Solicitudes> Solicitudes { get; set; }
        public DbSet<Mecanicos> Mecanicos { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Mecanicos>().HasData(new Mecanicos
        {
            MecanicoId = 1,
            Nombres = "Samuel",
            Area = "Electricista",
            Telefono = "809-234-5413",
            Disponible = 0   

        });
          modelBuilder.Entity<Mecanicos>().HasData(new Mecanicos
            {
                MecanicoId = 2,
                Nombres = "Elianny",
                Area = "Gomero",
                Telefono = "809-234-5413",
                Disponible = 0

            });
            modelBuilder.Entity<Mecanicos>().HasData(new Mecanicos
            {
                MecanicoId = 3,
                Nombres = "Enel",
                Area = "Reparador de cremallera",
                Telefono = "809-23-5413",
                Disponible = 0

            });
        }
    }
}
