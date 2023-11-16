using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class DodaliSmoStudente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojIndexa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumUpisa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrzavaRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BrojIndexa", "DatumUpisa", "DrzavaRodjenja", "GradRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { new Guid("590fe852-1e90-488b-9dac-9f399ac224a0"), "036011/20", new DateTime(2020, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6441), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" },
                    { new Guid("76295bb0-6f4f-4412-8c32-2f538ba43e93"), "058441/21", new DateTime(2021, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6474), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("9b124230-d629-4fc4-b106-a17892b04056"), "088711/20", new DateTime(2020, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6487), "Srbija", "Novi Pazar", "Hamza", "Delic" },
                    { new Guid("a8337fae-2f75-4f41-bde3-32318592053a"), "038511/20", new DateTime(2020, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6480), "Srbija", "Tutin", "Hasim", "Tutic" },
                    { new Guid("b3377045-96c2-464a-a315-67675fadab01"), "036035/21", new DateTime(2021, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6466), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
