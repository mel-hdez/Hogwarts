using SQLite;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SQLiteNetExtensions.Attributes;

namespace Hogwarts.Data
{
    public class DataContext : DbContext
    {
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Plantel> Planteles { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PermisoCumpleano> PermisoCumpleanos { get; set; }
        public DbSet<PermisoEconomico> PermisoEconomicos { get; set; }
        public DbSet<PermisoHora> PermisoHoras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opts)
            => opts.UseSqlite(@"Data Source= app.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plantel>().HasData(new Plantel[]{
                new Plantel{ Id=0501, Nombre="Plantel Zapopan" },
                new Plantel{ Id=0601, Nombre="Plantel Tlaquepaque" },
                new Plantel{ Id=0701, Nombre="Plantel Guadalajara" },
            });

            modelBuilder.Entity<Departamento>().HasData(new Departamento[]{
                new Departamento{ Id= 1301, Nombre="Departamento Software", PlantelId=0501},
                new Departamento{ Id= 1302, Nombre="Departamento Diseño", PlantelId=0501},
                new Departamento{ Id= 1401, Nombre="Departamento Computo", PlantelId=0601},
                new Departamento{ Id= 1402, Nombre="Departamento Ingenierías", PlantelId=0601},
                new Departamento{ Id= 1501, Nombre="Departamento Pruebas", PlantelId=0701},
                new Departamento{ Id= 1502, Nombre="Departamento Administracion", PlantelId=0701},
            });

            modelBuilder.Entity<TipoUsuario>().HasData(new TipoUsuario[]{
                new TipoUsuario { Id=1, Tipo="Jefe" },
                new TipoUsuario { Id=2, Tipo="Empleado" }
            });

            modelBuilder.Entity<Usuario>().HasData(new Usuario[]{
                //Jefes
                new Usuario{ Id=3312, PrimerNombre="Vicente", SegundoNombre="Gonzalez Rueda", Correo="alex1123nel@gmail.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(2001,02,26, 12, 30, 0), FechaIngreso= new DateTime(2020,03,03, 12, 30, 0), DepartamentoId=1301, TipoUsuarioId=1 },
                new Usuario{ Id=3313, PrimerNombre="Teresita", SegundoNombre="Barajas Sainz", Correo="teresitaCS@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1991,08,25, 12, 30, 0), FechaIngreso= new DateTime(2021,03,03, 12, 30, 0), DepartamentoId=1302, TipoUsuarioId=1 }, 
                new Usuario{ Id=3314, PrimerNombre="Andres", SegundoNombre="Salamanca Sol", Correo="AndresSS@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1980,11,03, 12, 30, 0), FechaIngreso= new DateTime(2021,01,08, 12, 30, 0), DepartamentoId=1401, TipoUsuarioId=1 },
                new Usuario{ Id=3315, PrimerNombre="Gracia", SegundoNombre="Zurita Armengol", Correo="GraciaZA@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1995,10,14, 12, 30, 0), FechaIngreso= new DateTime(2015,02,18, 12, 30, 0), DepartamentoId=1402, TipoUsuarioId=1 },
                new Usuario{ Id=3316, PrimerNombre="Delfina", SegundoNombre="Almeida Azorin", Correo="DelgfinaAA@gmail.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1991,08,15, 12, 30, 0), FechaIngreso= new DateTime(2015,10,08, 12, 30, 0), DepartamentoId=1501, TipoUsuarioId=1 }, 
                new Usuario{ Id=3317, PrimerNombre="Ramona", SegundoNombre="González Carrazco", Correo="RamonaGC@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1987,06,14, 12, 30, 0), FechaIngreso= new DateTime(2020,07,28, 12, 30, 0), DepartamentoId=1502, TipoUsuarioId=1 },
                //Empleados
                new Usuario{ Id=3318, PrimerNombre="Eligio", SegundoNombre="Hernandez Cadenas", Correo="EligioHD@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1985,06,28, 12, 30, 0), FechaIngreso= new DateTime(2020,04,19, 12, 30, 0), DepartamentoId=1301, TipoUsuarioId=2 }, 
                new Usuario{ Id=3319, PrimerNombre="Rufina", SegundoNombre="Baró Bravo", Correo="RufinaBB@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1983,04,28, 12, 30, 0), FechaIngreso= new DateTime(2016,01,29, 12, 30, 0), DepartamentoId=1301, TipoUsuarioId=2 }, 
                new Usuario{ Id=3320, PrimerNombre="Rafael", SegundoNombre="Batlle Carreras", Correo="RafaelBC@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1997,12,04, 12, 30, 0), FechaIngreso= new DateTime(2018,12,31, 12, 30, 0), DepartamentoId=1301, TipoUsuarioId=2 }, 
                new Usuario{ Id=3321, PrimerNombre="Gonzalo", SegundoNombre="Morillo Torres", Correo="GonzaloMT@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1995,01,26, 12, 30, 0), FechaIngreso= new DateTime(2016,07,29, 12, 30, 0), DepartamentoId=1302, TipoUsuarioId=2 }, 
                new Usuario{ Id=3322, PrimerNombre="Alejandra", SegundoNombre="Garcia Ayllon", Correo="AlejandraGD@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1999,09,21, 12, 30, 0), FechaIngreso= new DateTime(2015,10,26, 12, 30, 0), DepartamentoId=1302, TipoUsuarioId=2 }, 
                new Usuario{ Id=3323, PrimerNombre="Carina", SegundoNombre="Cabrera Enriquez", Correo="CarinaCCE@howarts.com", Contrasena="3312",
                    FechaNacimiento= new DateTime(1985,10,30, 12, 30, 0), FechaIngreso= new DateTime(2021,03,05, 12, 30, 0), DepartamentoId=1302, TipoUsuarioId=2 }, 
            });
        }

    }

    public class Plantel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [OneToMany]
        public List<Departamento> Departamentos { get; set; }
    }

    public class Departamento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [OneToMany]
        public List<Usuario> Usuarios { get; set; }
        [ForeignKey(typeof(Plantel))]
        public int PlantelId { get; set; }
    }

    public class TipoUsuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Tipo { get; set; }
        [OneToMany]
        public List<Usuario> Usuarios { get; set; }
    }

    public class PermisoCumpleano
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool Status { get; set;}
        public DateTime Fecha { get; set; }
        [ForeignKey(typeof(Usuario))]
        public int UsuarioId { get; set; }
    }

    public class PermisoEconomico
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool Status { get; set;}

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        [ForeignKey(typeof(Usuario))]
        public int UsuarioId { get; set; }
    }

    public class PermisoHora
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool Status { get; set;}
        public string Motivo { get; set; }
        public string Horario { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey(typeof(Usuario))]
        public int UsuarioId { get; set; }
    }

    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        [OneToMany]
        public List<PermisoCumpleano> PermisoCumpleanos { get; set; }
        [OneToMany]
        public List<PermisoEconomico> PermisoEconomicos { get; set; }
        [OneToMany]
        public List<PermisoHora> PermisoHoras { get; set; }
        [ForeignKey(typeof(Departamento))]
        public int DepartamentoId { get; set; }
        [ForeignKey(typeof(TipoUsuario))]
        public int TipoUsuarioId { get; set; }
    }
}

