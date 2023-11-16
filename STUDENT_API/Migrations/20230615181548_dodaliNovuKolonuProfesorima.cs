using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class dodaliNovuKolonuProfesorima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "NekaKolona",
                table: "Professors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BrojIndexa", "DatumUpisa", "DrzavaRodjenja", "GradRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { new Guid("3e8a663d-c2bc-4c06-9974-1eb8bb1c4852"), "038511/20", new DateTime(2020, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5795), "Srbija", "Tutin", "Hasim", "Tutic" },
                    { new Guid("af7e064d-d5e5-404a-ba92-a0e94751544f"), "036035/21", new DateTime(2021, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5787), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" },
                    { new Guid("b8f01366-0eae-4bda-8c51-ff6a727d08c8"), "058441/21", new DateTime(2021, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5792), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("e199f2cb-32fb-4e1d-af50-a9cd20f2f68c"), "088711/20", new DateTime(2020, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5799), "Srbija", "Novi Pazar", "Hamza", "Delic" },
                    { new Guid("ef3d4ed3-45fb-4e5f-a2ed-bc029c5a10ad"), "036011/20", new DateTime(2020, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5705), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3e8a663d-c2bc-4c06-9974-1eb8bb1c4852"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("af7e064d-d5e5-404a-ba92-a0e94751544f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b8f01366-0eae-4bda-8c51-ff6a727d08c8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e199f2cb-32fb-4e1d-af50-a9cd20f2f68c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ef3d4ed3-45fb-4e5f-a2ed-bc029c5a10ad"));

            migrationBuilder.DropColumn(
                name: "NekaKolona",
                table: "Professors");

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
    }
}
