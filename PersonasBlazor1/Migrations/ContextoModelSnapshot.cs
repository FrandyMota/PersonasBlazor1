﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonasBlazor1.DAL;

namespace PersonasBlazor1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("PersonasBlazor1.Models.Moras", b =>
                {
                    b.Property<int>("MoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("MoraId");

                    b.ToTable("Moras");
                });

            modelBuilder.Entity("PersonasBlazor1.Models.MorasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("MoraId");

                    b.ToTable("MorasDetalle");
                });

            modelBuilder.Entity("PersonasBlazor1.Models.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(13);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(14);

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("PersonasBlazor1.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("PersonasBlazor1.Models.MorasDetalle", b =>
                {
                    b.HasOne("PersonasBlazor1.Models.Moras", null)
                        .WithMany("MoraDetalle")
                        .HasForeignKey("MoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonasBlazor1.Models.Prestamos", b =>
                {
                    b.HasOne("PersonasBlazor1.Models.Personas", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
