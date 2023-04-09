﻿// <auto-generated />
using Aplicada2Api.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aplicada2Api.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230409134445_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Aplicada2Api.Models.Citas", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CitaId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Mecanicos", b =>
                {
                    b.Property<int>("MecanicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MecanicoId");

                    b.ToTable("Mecanicos");

                    b.HasData(
                        new
                        {
                            MecanicoId = 1,
                            Area = "Electricista",
                            Disponible = 0,
                            Nombres = "Samuel",
                            Telefono = "809-234-5413"
                        },
                        new
                        {
                            MecanicoId = 2,
                            Area = "Gomero",
                            Disponible = 0,
                            Nombres = "Elianny",
                            Telefono = "809-234-5413"
                        },
                        new
                        {
                            MecanicoId = 3,
                            Area = "Reparador de cremallera",
                            Disponible = 0,
                            Nombres = "Enel",
                            Telefono = "809-23-5413"
                        });
                });

            modelBuilder.Entity("Aplicada2Api.Models.Reportes", b =>
                {
                    b.Property<int>("ReporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReporteId");

                    b.ToTable("Reportes");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Solicitudes", b =>
                {
                    b.Property<int>("SolicitudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SolicitudId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Vehiculos", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}