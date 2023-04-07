﻿// <auto-generated />
using System;
using Aplicada2Api.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aplicada2Api.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CitaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MecanicoId");

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

                    b.HasIndex("VehiculoId");

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

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReporteId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MecanicoId");

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

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SolicitudId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MecanicoId");

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

                    b.Property<DateTime>("year")
                        .HasColumnType("TEXT");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Citas", b =>
                {
                    b.HasOne("Aplicada2Api.Models.Clientes", "clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aplicada2Api.Models.Mecanicos", "mecanicos")
                        .WithMany()
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clientes");

                    b.Navigation("mecanicos");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Clientes", b =>
                {
                    b.HasOne("Aplicada2Api.Models.Vehiculos", "vehiculos")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vehiculos");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Reportes", b =>
                {
                    b.HasOne("Aplicada2Api.Models.Clientes", "clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aplicada2Api.Models.Mecanicos", "mecanicos")
                        .WithMany()
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clientes");

                    b.Navigation("mecanicos");
                });

            modelBuilder.Entity("Aplicada2Api.Models.Solicitudes", b =>
                {
                    b.HasOne("Aplicada2Api.Models.Clientes", "clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aplicada2Api.Models.Mecanicos", "mecanicos")
                        .WithMany()
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clientes");

                    b.Navigation("mecanicos");
                });
#pragma warning restore 612, 618
        }
    }
}
