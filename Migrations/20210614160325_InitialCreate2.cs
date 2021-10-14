using Microsoft.EntityFrameworkCore.Migrations;

namespace Hogwarts.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "id", "clavePlantel", "nombrePlantel" },
                values: new object[] { 501, "501PNY", "Plantel Nueva York" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "id", "clavePlantel", "nombrePlantel" },
                values: new object[] { 502, "502PLA", "Plantel Los Angeles" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "id", "clavePlantel", "nombrePlantel" },
                values: new object[] { 503, "503PMG", "Plantel Texas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planteles",
                keyColumn: "id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Planteles",
                keyColumn: "id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Planteles",
                keyColumn: "id",
                keyValue: 503);
        }
    }
}
