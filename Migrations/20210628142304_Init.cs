using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hogwarts.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planteles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planteles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    PlantelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamentos_Planteles_PlantelId",
                        column: x => x.PlantelId,
                        principalTable: "Planteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrimerNombre = table.Column<string>(type: "TEXT", nullable: true),
                    SegundoNombre = table.Column<string>(type: "TEXT", nullable: true),
                    Correo = table.Column<string>(type: "TEXT", nullable: true),
                    Contrasena = table.Column<string>(type: "TEXT", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DepartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoUsuarios_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermisoCumpleanos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisoCumpleanos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermisoCumpleanos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermisoEconomicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisoEconomicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermisoEconomicos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermisoHoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Motivo = table.Column<string>(type: "TEXT", nullable: true),
                    Horario = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisoHoras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermisoHoras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 501, "Plantel Zapopan" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 601, "Plantel Tlaquepaque" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 701, "Plantel Guadalajara" });

            migrationBuilder.InsertData(
                table: "TipoUsuarios",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 1, "Jefe" });

            migrationBuilder.InsertData(
                table: "TipoUsuarios",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 2, "Empleado" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre", "PlantelId" },
                values: new object[] { 1301, "Departamento Software", 501 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre", "PlantelId" },
                values: new object[] { 1302, "Departamento Diseño", 501 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre", "PlantelId" },
                values: new object[] { 1401, "Departamento Computo", 601 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre", "PlantelId" },
                values: new object[] { 1402, "Departamento Ingenierías", 601 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre", "PlantelId" },
                values: new object[] { 1501, "Departamento Pruebas", 701 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre", "PlantelId" },
                values: new object[] { 1502, "Departamento Administracion", 701 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3312, "3312", "alex1123nel@gmail.com", 1301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2014), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1973), "Vicente", "Gonzalez Rueda", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3318, "3312", "EligioHD@howarts.com", 1301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1951), "Eligio", "Hernandez Cadenas", 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3319, "3312", "RufinaBB@howarts.com", 1301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1986), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1951), "Rufina", "Baró Bravo", 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3320, "3312", "RafaelBC@howarts.com", 1301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981), "Rafael", "Batlle Carreras", 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3313, "3312", "teresitaCS@howarts.com", 1302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2015), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1958), "Teresita", "Barajas Sainz", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3321, "3312", "GonzaloMT@howarts.com", 1302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1980), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Gonzalo", "Morillo Torres", 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3322, "3312", "AlejandraGD@howarts.com", 1302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1969), "Alejandra", "Garcia Ayllon", 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3323, "3312", "CarinaCCE@howarts.com", 1302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2013), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1945), "Carina", "Cabrera Enriquez", 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3314, "3312", "AndresSS@howarts.com", 1401, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2012), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Andres", "Salamanca Sol", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3315, "3312", "GraciaZA@howarts.com", 1402, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Gracia", "Zurita Armengol", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3316, "3312", "DelgfinaAA@gmail.com", 1501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Delfina", "Almeida Azorin", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Contrasena", "Correo", "DepartamentoId", "FechaIngreso", "FechaNacimiento", "PrimerNombre", "SegundoNombre", "TipoUsuarioId" },
                values: new object[] { 3317, "3312", "RamonaGC@howarts.com", 1502, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1985), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1967), "Ramona", "González Carrazco", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PlantelId",
                table: "Departamentos",
                column: "PlantelId");

            migrationBuilder.CreateIndex(
                name: "IX_PermisoCumpleanos_UsuarioId",
                table: "PermisoCumpleanos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PermisoEconomicos_UsuarioId",
                table: "PermisoEconomicos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PermisoHoras_UsuarioId",
                table: "PermisoHoras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DepartamentoId",
                table: "Usuarios",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermisoCumpleanos");

            migrationBuilder.DropTable(
                name: "PermisoEconomicos");

            migrationBuilder.DropTable(
                name: "PermisoHoras");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "TipoUsuarios");

            migrationBuilder.DropTable(
                name: "Planteles");
        }
    }
}
