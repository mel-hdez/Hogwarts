﻿// <auto-generated />
using System;
using Hogwarts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hogwarts.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Hogwarts.Data.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlantelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlantelId");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1301,
                            Nombre = "Departamento Software",
                            PlantelId = 501
                        },
                        new
                        {
                            Id = 1302,
                            Nombre = "Departamento Diseño",
                            PlantelId = 501
                        },
                        new
                        {
                            Id = 1401,
                            Nombre = "Departamento Computo",
                            PlantelId = 601
                        },
                        new
                        {
                            Id = 1402,
                            Nombre = "Departamento Ingenierías",
                            PlantelId = 601
                        },
                        new
                        {
                            Id = 1501,
                            Nombre = "Departamento Pruebas",
                            PlantelId = 701
                        },
                        new
                        {
                            Id = 1502,
                            Nombre = "Departamento Administracion",
                            PlantelId = 701
                        });
                });

            modelBuilder.Entity("Hogwarts.Data.PermisoCumpleano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PermisoCumpleanos");
                });

            modelBuilder.Entity("Hogwarts.Data.PermisoEconomico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PermisoEconomicos");
                });

            modelBuilder.Entity("Hogwarts.Data.PermisoHora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Horario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motivo")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PermisoHoras");
                });

            modelBuilder.Entity("Hogwarts.Data.Plantel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Planteles");

                    b.HasData(
                        new
                        {
                            Id = 501,
                            Nombre = "Plantel Zapopan"
                        },
                        new
                        {
                            Id = 601,
                            Nombre = "Plantel Tlaquepaque"
                        },
                        new
                        {
                            Id = 701,
                            Nombre = "Plantel Guadalajara"
                        });
                });

            modelBuilder.Entity("Hogwarts.Data.TipoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TipoUsuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tipo = "Jefe"
                        },
                        new
                        {
                            Id = 2,
                            Tipo = "Empleado"
                        });
                });

            modelBuilder.Entity("Hogwarts.Data.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contrasena")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoUsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 3312,
                            Contrasena = "3312",
                            Correo = "alex1123nel@gmail.com",
                            DepartamentoId = 1301,
                            FechaIngreso = new DateTime(2020, 3, 3, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(2001, 2, 26, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Vicente",
                            SegundoNombre = "Gonzalez Rueda",
                            TipoUsuarioId = 1
                        },
                        new
                        {
                            Id = 3313,
                            Contrasena = "3312",
                            Correo = "teresitaCS@howarts.com",
                            DepartamentoId = 1302,
                            FechaIngreso = new DateTime(2021, 3, 3, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1991, 8, 25, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Teresita",
                            SegundoNombre = "Barajas Sainz",
                            TipoUsuarioId = 1
                        },
                        new
                        {
                            Id = 3314,
                            Contrasena = "3312",
                            Correo = "AndresSS@howarts.com",
                            DepartamentoId = 1401,
                            FechaIngreso = new DateTime(2021, 1, 8, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1980, 11, 3, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Andres",
                            SegundoNombre = "Salamanca Sol",
                            TipoUsuarioId = 1
                        },
                        new
                        {
                            Id = 3315,
                            Contrasena = "3312",
                            Correo = "GraciaZA@howarts.com",
                            DepartamentoId = 1402,
                            FechaIngreso = new DateTime(2015, 2, 18, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1995, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Gracia",
                            SegundoNombre = "Zurita Armengol",
                            TipoUsuarioId = 1
                        },
                        new
                        {
                            Id = 3316,
                            Contrasena = "3312",
                            Correo = "DelgfinaAA@gmail.com",
                            DepartamentoId = 1501,
                            FechaIngreso = new DateTime(2015, 10, 8, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1991, 8, 15, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Delfina",
                            SegundoNombre = "Almeida Azorin",
                            TipoUsuarioId = 1
                        },
                        new
                        {
                            Id = 3317,
                            Contrasena = "3312",
                            Correo = "RamonaGC@howarts.com",
                            DepartamentoId = 1502,
                            FechaIngreso = new DateTime(2020, 7, 28, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1987, 6, 14, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Ramona",
                            SegundoNombre = "González Carrazco",
                            TipoUsuarioId = 1
                        },
                        new
                        {
                            Id = 3318,
                            Contrasena = "3312",
                            Correo = "EligioHD@howarts.com",
                            DepartamentoId = 1301,
                            FechaIngreso = new DateTime(2020, 4, 19, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1985, 6, 28, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Eligio",
                            SegundoNombre = "Hernandez Cadenas",
                            TipoUsuarioId = 2
                        },
                        new
                        {
                            Id = 3319,
                            Contrasena = "3312",
                            Correo = "RufinaBB@howarts.com",
                            DepartamentoId = 1301,
                            FechaIngreso = new DateTime(2016, 1, 29, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1983, 4, 28, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Rufina",
                            SegundoNombre = "Baró Bravo",
                            TipoUsuarioId = 2
                        },
                        new
                        {
                            Id = 3320,
                            Contrasena = "3312",
                            Correo = "RafaelBC@howarts.com",
                            DepartamentoId = 1301,
                            FechaIngreso = new DateTime(2018, 12, 31, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1997, 12, 4, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Rafael",
                            SegundoNombre = "Batlle Carreras",
                            TipoUsuarioId = 2
                        },
                        new
                        {
                            Id = 3321,
                            Contrasena = "3312",
                            Correo = "GonzaloMT@howarts.com",
                            DepartamentoId = 1302,
                            FechaIngreso = new DateTime(2016, 7, 29, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1995, 1, 26, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Gonzalo",
                            SegundoNombre = "Morillo Torres",
                            TipoUsuarioId = 2
                        },
                        new
                        {
                            Id = 3322,
                            Contrasena = "3312",
                            Correo = "AlejandraGD@howarts.com",
                            DepartamentoId = 1302,
                            FechaIngreso = new DateTime(2015, 10, 26, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1999, 9, 21, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Alejandra",
                            SegundoNombre = "Garcia Ayllon",
                            TipoUsuarioId = 2
                        },
                        new
                        {
                            Id = 3323,
                            Contrasena = "3312",
                            Correo = "CarinaCCE@howarts.com",
                            DepartamentoId = 1302,
                            FechaIngreso = new DateTime(2021, 3, 5, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1985, 10, 30, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            PrimerNombre = "Carina",
                            SegundoNombre = "Cabrera Enriquez",
                            TipoUsuarioId = 2
                        });
                });

            modelBuilder.Entity("Hogwarts.Data.Departamento", b =>
                {
                    b.HasOne("Hogwarts.Data.Plantel", null)
                        .WithMany("Departamentos")
                        .HasForeignKey("PlantelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hogwarts.Data.PermisoCumpleano", b =>
                {
                    b.HasOne("Hogwarts.Data.Usuario", null)
                        .WithMany("PermisoCumpleanos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hogwarts.Data.PermisoEconomico", b =>
                {
                    b.HasOne("Hogwarts.Data.Usuario", null)
                        .WithMany("PermisoEconomicos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hogwarts.Data.PermisoHora", b =>
                {
                    b.HasOne("Hogwarts.Data.Usuario", null)
                        .WithMany("PermisoHoras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hogwarts.Data.Usuario", b =>
                {
                    b.HasOne("Hogwarts.Data.Departamento", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hogwarts.Data.TipoUsuario", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hogwarts.Data.Departamento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Hogwarts.Data.Plantel", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Hogwarts.Data.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Hogwarts.Data.Usuario", b =>
                {
                    b.Navigation("PermisoCumpleanos");

                    b.Navigation("PermisoEconomicos");

                    b.Navigation("PermisoHoras");
                });
#pragma warning restore 612, 618
        }
    }
}
