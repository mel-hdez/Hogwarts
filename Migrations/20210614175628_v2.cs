using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hogwarts.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "claveJefe",
                table: "Jefes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaNacimiento",
                table: "Empleados",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaIngreso",
                table: "Empleados",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "claveEmpleado",
                table: "Empleados",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 201, null, "Administración", 501 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 202, null, "Desarrollo de Software", 501 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 203, null, "Quimico en Farmacos", 501 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 204, null, "Magia Negra", 502 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 205, null, "Magia Blanca", 502 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 206, null, "Alquimia", 503 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 207, null, "Rituales de Invocación", 503 });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "id", "PlantelModelid", "nombreDepto", "plantelId" },
                values: new object[] { 208, null, "Vision del Futuro", 503 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 51, null, null, null, null, "Martinez", "Sierra", "ABILSM", "a1b2c3d4", "AbilioESM@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Abilio", 80, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 50, null, null, null, null, "Escribano", "Jove", "MIREJE", "a1b2c3d4", "MireiaJE@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Mireia", 81, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 49, null, null, null, null, "Oliva", "Suárez", "AMBASD", "a1b2c3d4", "AmbarSD@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1964), "Ámbar", 82, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 48, null, null, null, null, "Segarra", "Andrade", "ASDRAS", "a1b2c3d4", "AsdrubalAAS@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Asdrubal", 83, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 47, null, null, null, null, "Lozano", "Agudo", "JOSEAL", "a1b2c3d4", "JoseMAL@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972), "Jose", 84, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 46, null, null, null, null, "Alberola", "Pacheco", "ANTOPA", "a1b2c3d4", "AntonioPA@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Antonio", 85, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 45, null, null, null, null, "Saldaña", "Colomer", "VASCCS", "a1b2c3d4", "VascoCS@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2013), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Vasco", 86, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 41, null, null, null, null, "Viana", "Baró", "GUILBV", "a1b2c3d4", "GuillermoBV@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972), "Guillermo", 90, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 43, null, null, null, null, "Peláez", "Bejarano", "PLACBP", "a1b2c3d4", "PlacidoBP@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1957), "Plácido", 88, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 42, null, null, null, null, "Quesada", "Alemán", "HIPOAQ", "a1b2c3d4", "HipolitoAQ@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Hipólito", 89, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 52, null, null, null, null, "Figueroa", "Martinez", "ARISMD", "a1b2c3d4", "AristidesMD@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Aristides", 79, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 40, null, null, null, null, "Suárez", "Madrid", "GRACMS", "a1b2c3d4", "GracianaMS@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981), "Graciana", 91, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 39, null, null, null, null, "Alberto", "Tejera", "FELITA", "a1b2c3d4", "FelisaTA@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2013), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1957), "Felisa", 92, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 38, null, null, null, null, "Bravo", "Blanes", "GASTBB", "a1b2c3d4", "GastonBB@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1991), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1958), "Gastón", 93, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 44, null, null, null, null, "Salcedo", "Roselló", "DARIRS", "a1b2c3d4", "DarioRS@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1948), "Darío", 87, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 53, null, null, null, null, "deLledó", "Heredia", "MARTHD", "a1b2c3d4", "MartinaHD@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Martina", 78, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 58, null, null, null, null, "Galindo", "Suárez", "TOMASG", "a1b2c3d4", "TomasaSG@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Tomasa", 73, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 56, null, null, null, null, "Anglada", "Sanchez", "EDGASA", "a1b2c3d4", "EdgardoSA@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Edgardo", 75, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 70, null, null, null, null, "Ripoll", "Balaguer", "NEREBR", "a1b2c3d4", "NereaBR@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1970), "Nerea", 61, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 69, null, null, null, null, "Bejarano", "Iñiguez", "AMARIB", "a1b2c3d4", "AmarilisIB@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972), "Amarilis", 62, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 68, null, null, null, null, "Cuervo", "Guzmán", "LUISGC", "a1b2c3d4", "LuisMGC@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Luis", 63, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 67, null, null, null, null, "Godoy", "Peralta", "VASCPG", "a1b2c3d4", "VascoPG@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Vasco", 64, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 66, null, null, null, null, "Salinas", "Frutos", "RICOFS", "a1b2c3d4", "RicoFS@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Rico", 65, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 65, null, null, null, null, "Montaña", "Salas", "DANISM", "a1b2c3d4", "DaniloSM@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981), "Danilo", 66, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 55, null, null, null, null, "Zabala", "Barreda", "MARIBZ", "a1b2c3d4", "MariselaBZ@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Marisela", 76, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 64, null, null, null, null, "Riera", "Peñalver", "EVAPER", "a1b2c3d4", "EvaPR@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Eva", 67, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 62, null, null, null, null, "Domínguez", "Casal", "DIEGCD", "a1b2c3d4", "DiegoCD@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Diego", 69, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 61, null, null, null, null, "deAcero", "Modesto", "AMPAMD", "a1b2c3d4", "AmparoMD@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Amparo", 70, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 60, null, null, null, null, "Vicente", "Barriga", "MATIBV", "a1b2c3d4", "MatildeBV@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2010), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1967), "Matilde", 71, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 59, null, null, null, null, "Peñalver", "Garriga", "SATUGP", "a1b2c3d4", "SaturninoGP@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981), "Saturnino", 72, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 37, null, null, null, null, "Mosquera", "Mur", "AZENMM", "a1b2c3d4", "AzenethMM@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1973), "Azeneth", 94, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 57, null, null, null, null, "Godoy", "Baró", "EUFEBG", "a1b2c3d4", "EufemiaBG@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2007), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972), "Eufemia", 74, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 63, null, null, null, null, "Guitart", "Barón", "ANGEBG", "a1b2c3d4", "AngelitaBG@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1961), "Angelita", 68, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 36, null, null, null, null, "Arellano", "Caro", "TRINCA", "a1b2c3d4", "TrinidadCA@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1953), "Trinidad", 60, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 54, null, null, null, null, "Peláez", "Colomer", "BERNCP", "a1b2c3d4", "BernabeCP@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1973), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), "Bernabé", 77, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 34, null, null, null, null, "Torrents", "Cases", "LUZCAT", "a1b2c3d4", "LuzMB@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Luz", 46, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 14, null, null, null, null, "Teruel", "Ocaña", "LARAOT", "a1b2c3d4", "LaraOT@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2001), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1954), "Lara", 32, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 13, null, null, null, null, "Bayo", "Robledo", "XAVIRB", "a1b2c3d4", "XavierRB@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Xavier", 33, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 12, null, null, null, null, "Rivero", "Llorens", "MACULR", "a1b2c3d4", "MaximoLR@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2004), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1954), "Máximo", 34, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 11, null, null, null, null, "Ferrando", "Riquelme", "GUSTRF", "a1b2c3d4", "GustavoRF@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Gustavo", 35, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 10, null, null, null, null, "Sáez", "Tapia", "NOELTS", "a1b2c3d4", "NoeliaTS@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1987), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1967), "Noelia", 36, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 9, null, null, null, null, "Valero", "Figueras", "NACIFV", "a1b2c3d4", "NacioFV@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2007), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1961), "Nacio", 8, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 15, null, null, null, null, "Rueda", "Alatorre", "TIBUAD", "a1b2c3d4", "TiburcioAD@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1964), "Tiburcio", 31, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 8, null, null, null, null, "Riba", "Robles", "NOEMRR", "a1b2c3d4", "NoemíRR@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1963), "Noemí", 9, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 5, null, null, null, null, "Heras", "Ribes", "ALMARH", "a1b2c3d4", "AlmaRH@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1987), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1977), "Alma", 12, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 4, null, null, null, null, "Peláez", "Julián", "MARIJP", "a1b2c3d4", "MaritaJP@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1970), "Marita", 13, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 3, null, null, null, null, "Casanovas", "Costa", "AMANCC", "a1b2c3d4", "AmanacioCC@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1980), "Amancio", 7, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 2, null, null, null, null, "Molina", "Asensio", "HUJAAM", "a1b2c3d4", "HujoJAM@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1960), "Hugo", 4, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 1, null, null, null, null, "Gil", "Cerro", "MARCCG", "a1b2c3d4", "MarcianoCG@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Marciano", 3, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 35, null, null, null, null, "Cañizares", "Pedro", "ABRIPC", "a1b2c3d4", "AbrilPC@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1961), "Abril", 45, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 6, null, null, null, null, "Peña", "Ros", "CELERP", "a1b2c3d4", "CelestinoRP@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Celestino", 11, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 16, null, null, null, null, "Villaverde", "Isern", "CARIIV", "a1b2c3d4", "CarinaIV@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1977), "Carina", 30, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 7, null, null, null, null, "Rocamora", "Bello", "OFELBR", "a1b2c3d4", "OfeliaBR@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1952), "Ofelia", 10, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 29, null, null, null, null, "Montenegro", "Ureña", "MAXIUM", "a1b2c3d4", "MaximinioUM@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Maximino", 51, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 33, null, null, null, null, "Becerra", "Martín", "CORAMB", "a1b2c3d4", "CoralMB@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1991), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1969), "Coral", 47, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 32, null, null, null, null, "Álvarez", "Moliner", "AMANMA", "a1b2c3d4", "AmandoMA@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Amando", 48, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 31, null, null, null, null, "Angulo", "Donoso", "SAJODA", "a1b2c3d4", "SantiagoJDA@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1967), "Santiago", 49, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 30, null, null, null, null, "Quintana", "Mora", "AMPADQ", "a1b2c3d4", "AmparoDQ@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), "Amparo", 50, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 28, null, null, null, null, "Palau", "Navarro", "FLAVNP", "a1b2c3d4", "FlavioNP@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), "Flavio", 52, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 27, null, null, null, null, "Arnal", "Montesinos", "ROBEMA", "a1b2c3d4", "RobertaMA@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2006), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Roberta", 53, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 25, null, null, null, null, "Pardo", "Lerma", "ROCILP", "a1b2c3d4", "RocioLP@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1982), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1967), "Rocío", 55, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 26, null, null, null, null, "Palomino", "Aguilera", "RENAAP", "a1b2c3d4", "RenataAP@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1963), "Renata", 54, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 23, null, null, null, null, "Mata", "Valenciano", "GEROVM", "a1b2c3d4", "GeronimoVM@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1960), "Gerónimo", 57, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 22, null, null, null, null, "Baquero", "Quintana", "BRUNQB", "a1b2c3d4", "BrunildaQB@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), "Brunilda", 58, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 21, null, null, null, null, "Jiménez", "Cid", "EPIFCJ", "a1b2c3d4", "EpifanioCJ@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Epifanio", 59, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 20, null, null, null, null, "Torrent", "Giralt", "JOAQGT", "a1b2c3d4", "JoaquinEGT@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Joaquín", 26, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 19, null, null, null, null, "Soler", "Caro", "CUSTCS", "a1b2c3d4", "CustodiaCS', 'a1b2c3d4", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2011), "Custodia", 2, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 18, null, null, null, null, "Vilar", "Torrijos", "JOSETV", "a1b2c3d4", "JoseRTV@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1965), "Jose", 28, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 24, null, null, null, null, "Escalona", "Nevado", "MACANE", "a1b2c3d4", "MacariaNE@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1962), "Macaria", 56, 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DepartamentoModelid", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveEmpleado", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreEmpleado", "nominaId", "recuperacionId" },
                values: new object[] { 17, null, null, null, null, "Torrecilla", "Diéguez", "AMILDT", "a1b2c3d4", "AmilcarDT@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2001), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1958), "Amílcar", 29, 0 });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 64, "163749" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 62, "851467" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 63, "135494" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 49, "505050" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 66, "436871" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 67, "167491" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 61, "234578" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 68, "254163" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 65, "251849" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 60, "164287" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 52, "496587" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 58, "181916" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 57, "535659" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 56, "595751" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 55, "585254" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 54, "319647" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 53, "487953" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 51, "649785" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 50, "278541" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 69, "187349" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 59, "272624" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 70, "487591" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 87, "524681" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 72, "187898" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 48, "674485" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 92, "586545" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 91, "712933" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 90, "518972" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 89, "214536" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 88, "487593" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 86, "134682" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 85, "842157" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 84, "946298" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 71, "315963" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 83, "324962" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 81, "999999" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 80, "174691" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 79, "346854" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 78, "267496" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 77, "923158" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 76, "183468" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 75, "762649" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 74, "454985" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 73, "123252" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 82, "222222" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 47, "679428" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 8, "605013" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 45, "938271" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 20, "518760" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 19, "362510" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 18, "354982" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 17, "506048" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 16, "254961" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 15, "215151" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 14, "149875" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 13, "131313" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 12, "121212" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 21, "263159" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 11, "113564" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 9, "597815" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 93, "428674" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 7, "901546" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 6, "213065" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 5, "469832" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 4, "749652" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 3, "789846" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 2, "789845" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 1, "546521" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 10, "301578" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 46, "555555" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 22, "223522" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 24, "948152" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 44, "283917" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 43, "197346" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 42, "163497" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 41, "794613" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 40, "134679" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 39, "319487" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 38, "489612" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 37, "879642" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 36, "497816" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 23, "315264" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 35, "651460" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 33, "306197" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 32, "948673" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 31, "316597" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 30, "356978" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 29, "292929" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 28, "289696" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 27, "568941" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 26, "789154" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 25, "309780" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 34, "645891" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "id", "numNomina" },
                values: new object[] { 94, "789259" });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 2, null, null, null, "Sainz", "Cerdá", "TERECS", "a1b2c3d4", "teresitaCS@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2015), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1958), "Teresita", 2 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 6, null, null, null, "Carrasco", "González", "RAMOGC", "a1b2c3d4", "RamonaGC@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1985), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1967), "Ramona", 25 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 21, null, null, null, "Angulo", "Ortuño", "HERMOA", "a1b2c3d4", "HerminiaOA@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1987), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1977), "Herminia", 40 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 15, null, null, null, "Sacristán", "Rosales", "JOSERS", "a1b2c3d4", "JoseMRS@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2013), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Jose", 16 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 7, null, null, null, "Cadenas", "Hernandez", "ELIGHD", "a1b2c3d4", "EligioHD@howarts.com", 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1951), "Eligio", 24 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 18, null, null, null, "Baeza", "Saldaña", "AUROSB", "a1b2c3d4", "AuroraSB@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1989), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Aurora", 43 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 16, null, null, null, "Lopez", "Herranz", "ESTRHL", "a1b2c3d4", "EstrellaHL@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972), "Estrella", 15 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 8, null, null, null, "Bravo", "Baró", "RUFIBB", "a1b2c3d4", "RufinaBB@howarts.com", 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1986), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1951), "Rufina", 23 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 24, null, null, null, "Baquero", "Quintana", "BRUNQB", "a1b2c3d4", "BrunildaQB@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1973), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), "Brunilda", 37 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 9, null, null, null, "Carreras", "Batlle", "RAFABC", "a1b2c3d4", "RafaelBC@howarts.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981), "Rafael", 22 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 5, null, null, null, "Azorin", "Almeida", "DELFAA", "a1b2c3d4", "DelgfinaAA@gmail.com", 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Delfina", 14 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 20, null, null, null, "Tejedor", "Llabrés", "GABRLT", "a1b2c3d4", "GabrielaLT@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1964), "Gabriela", 41 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 10, null, null, null, "Torres", "Morillo", "GONZMT", "a1b2c3d4", "GonzaloMT@howarts.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1980), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Gonzalo", 21 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 1, null, null, null, "Rueda", "González", "VIALGR", "adeuRVAGR", "alex1123nel@gmail.com", 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2014), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1973), "Vicente", 1 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 22, null, null, null, "Arellano", "Caro", "TRINCA", "a1b2c3d4", "TrinidadCA@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1954), "Trinidad", 39 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 11, null, null, null, "Ayllón", "Garcia", "ALEJGD", "a1b2c3d4", "AlejandraGD@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1979), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1969), "Alejandra", 20 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 4, null, null, null, "Armengol", "Zurita", "GRACZA", "a1b2c3d4", "GraciaZA@howarts.com", 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1971), "Gracia", 6 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 19, null, null, null, "Carretero", "Peinado", "MANUPC", "a1b2c3d4", "ManuPC@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1976), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1963), "Manu", 42 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 12, null, null, null, "Enríquez", "Cabrera", "CARICE", "a1b2c3d4", "CarinaCCE@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2013), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1945), "Carina", 19 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 3, null, null, null, "Sol", "Salamanca", "ANDRSS", "a1b2c3d4", "AndresSS@howarts.com", 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2012), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1966), "Andres", 5 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 17, null, null, null, "Ariza", "Benet", "HUGOBA", "a1b2c3d4", "HugoBA@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Hugo", 44 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 13, null, null, null, "Sarabia", "Diéguez", "DONADS", "a1b2c3d4", "DonatoDS@howarts.com", 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1993), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Donato", 18 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 14, null, null, null, "Catalán", "Sanchez", "ELIASC", "a1b2c3d4", "EliasSC@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "Elías", 17 });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "id", "NominaModelid", "PermisoModelid", "RecuperacionModelid", "apellidoMaterno", "apellidoPaterno", "claveJefe", "contrasena", "correo", "departamentoId", "fechaIngreso", "fechaNacimiento", "nombreJefe", "nominaId" },
                values: new object[] { 23, null, null, null, "Jiménez", "Cid", "EPIFCJ", "a1b2c3d4", "EpifanioCJ@howarts.com", 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1950), "Epifanio", 38 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Nominas",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DropColumn(
                name: "claveJefe",
                table: "Jefes");

            migrationBuilder.DropColumn(
                name: "claveEmpleado",
                table: "Empleados");

            migrationBuilder.AlterColumn<string>(
                name: "fechaNacimiento",
                table: "Empleados",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "fechaIngreso",
                table: "Empleados",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }
    }
}
