using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class makliKolonu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1feb2a79-aa15-46dc-a3a5-87751ca08663"), "058441/21", new DateTime(2021, 10, 15, 18, 18, 49, 913, DateTimeKind.Utc).AddTicks(5192), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("2ac18a15-6a0a-443b-bc32-f54b2af4a1fe"), "036035/21", new DateTime(2021, 10, 15, 18, 18, 49, 913, DateTimeKind.Utc).AddTicks(5188), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" },
                    { new Guid("398614b6-ba20-44e1-8f79-5839fd9720e5"), "038511/20", new DateTime(2020, 10, 15, 18, 18, 49, 913, DateTimeKind.Utc).AddTicks(5196), "Srbija", "Tutin", "Hasim", "Tutic" },
                    { new Guid("56e820f1-63eb-4eba-ba68-29caf66f0426"), "036011/20", new DateTime(2020, 10, 15, 18, 18, 49, 913, DateTimeKind.Utc).AddTicks(5166), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" },
                    { new Guid("d190931d-58fa-4ee0-9309-a61d7855dd4f"), "088711/20", new DateTime(2020, 10, 15, 18, 18, 49, 913, DateTimeKind.Utc).AddTicks(5200), "Srbija", "Novi Pazar", "Hamza", "Delic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1feb2a79-aa15-46dc-a3a5-87751ca08663"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2ac18a15-6a0a-443b-bc32-f54b2af4a1fe"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("398614b6-ba20-44e1-8f79-5839fd9720e5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("56e820f1-63eb-4eba-ba68-29caf66f0426"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d190931d-58fa-4ee0-9309-a61d7855dd4f"));

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
    }
}
