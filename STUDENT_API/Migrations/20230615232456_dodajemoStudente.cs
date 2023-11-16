using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class dodajemoStudente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BrojIndexa", "DatumUpisa", "DrzavaRodjenja", "GradRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { new Guid("001d6d22-a6cd-4e75-a39f-f22587454add"), "038511/20", new DateTime(2020, 10, 15, 23, 24, 56, 444, DateTimeKind.Utc).AddTicks(2795), "Srbija", "Tutin", "Hasim", "Tutic" },
                    { new Guid("2e5fe57f-d68d-4c69-b238-f1e9a64a6232"), "036035/21", new DateTime(2021, 10, 15, 23, 24, 56, 444, DateTimeKind.Utc).AddTicks(2789), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" },
                    { new Guid("5d337cec-b283-4563-ad16-9a86f9a6729f"), "058441/21", new DateTime(2021, 10, 15, 23, 24, 56, 444, DateTimeKind.Utc).AddTicks(2792), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("83c1640b-0c70-4f39-b7d1-3356976cb44a"), "036011/20", new DateTime(2020, 10, 15, 23, 24, 56, 444, DateTimeKind.Utc).AddTicks(2772), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" },
                    { new Guid("ec97391d-6aac-48dd-b652-846562f68418"), "088711/20", new DateTime(2020, 10, 15, 23, 24, 56, 444, DateTimeKind.Utc).AddTicks(2798), "Srbija", "Novi Pazar", "Hamza", "Delic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("001d6d22-a6cd-4e75-a39f-f22587454add"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2e5fe57f-d68d-4c69-b238-f1e9a64a6232"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5d337cec-b283-4563-ad16-9a86f9a6729f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("83c1640b-0c70-4f39-b7d1-3356976cb44a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ec97391d-6aac-48dd-b652-846562f68418"));

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
    }
}
