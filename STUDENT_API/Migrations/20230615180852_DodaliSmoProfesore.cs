using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class DodaliSmoProfesore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("590fe852-1e90-488b-9dac-9f399ac224a0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("76295bb0-6f4f-4412-8c32-2f538ba43e93"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9b124230-d629-4fc4-b106-a17892b04056"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a8337fae-2f75-4f41-bde3-32318592053a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b3377045-96c2-464a-a315-67675fadab01"));

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plata = table.Column<int>(type: "int", nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BrojIndexa", "DatumUpisa", "DrzavaRodjenja", "GradRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { new Guid("06188bb2-2edd-4968-83d4-4bc8f91b9b87"), "036011/20", new DateTime(2020, 10, 15, 18, 8, 51, 853, DateTimeKind.Utc).AddTicks(4765), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" },
                    { new Guid("15540931-7693-4ca9-9a66-69aa95a56ec4"), "038511/20", new DateTime(2020, 10, 15, 18, 8, 51, 853, DateTimeKind.Utc).AddTicks(4794), "Srbija", "Tutin", "Hasim", "Tutic" },
                    { new Guid("356de5ea-0a44-4dc8-880d-ba39cc9721c6"), "058441/21", new DateTime(2021, 10, 15, 18, 8, 51, 853, DateTimeKind.Utc).AddTicks(4790), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("55adcc4a-c546-4dfd-8e17-4364871246f3"), "036035/21", new DateTime(2021, 10, 15, 18, 8, 51, 853, DateTimeKind.Utc).AddTicks(4785), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" },
                    { new Guid("579c6d3d-ea5f-48ac-95b3-23c50dfc9f9a"), "088711/20", new DateTime(2020, 10, 15, 18, 8, 51, 853, DateTimeKind.Utc).AddTicks(4798), "Srbija", "Novi Pazar", "Hamza", "Delic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("06188bb2-2edd-4968-83d4-4bc8f91b9b87"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("15540931-7693-4ca9-9a66-69aa95a56ec4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("356de5ea-0a44-4dc8-880d-ba39cc9721c6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("55adcc4a-c546-4dfd-8e17-4364871246f3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("579c6d3d-ea5f-48ac-95b3-23c50dfc9f9a"));

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
    }
}
