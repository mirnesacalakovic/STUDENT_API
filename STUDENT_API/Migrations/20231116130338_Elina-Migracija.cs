using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class ElinaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("05d9f29c-dcf5-4034-adf6-3ae0aba0859e"), "038511/20", new DateTime(2021, 3, 16, 13, 3, 38, 486, DateTimeKind.Utc).AddTicks(9731), "Srbija", "Tutin", "Hasim", "Tutic" },
                    { new Guid("33d84c84-7a0c-4e5f-9816-3513f354dd16"), "088711/20", new DateTime(2021, 3, 16, 13, 3, 38, 486, DateTimeKind.Utc).AddTicks(9738), "ASajd", "Novi Sad", "ne znam", "Mirbejnd" },
                    { new Guid("50d7b5f7-8ca0-4425-8881-03fa18dcd5fc"), "036011/20", new DateTime(2021, 3, 16, 13, 3, 38, 486, DateTimeKind.Utc).AddTicks(9712), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" },
                    { new Guid("850ba02c-5af9-4c9b-a9f2-0f903bec689b"), "036035/21", new DateTime(2022, 3, 16, 13, 3, 38, 486, DateTimeKind.Utc).AddTicks(9727), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" },
                    { new Guid("a91ef508-098c-4d81-8aba-c2f904004238"), "058441/21", new DateTime(2022, 3, 16, 13, 3, 38, 486, DateTimeKind.Utc).AddTicks(9729), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("d74fa983-6276-4e07-8adb-cfccca241ff5"), "088711/20", new DateTime(2021, 3, 16, 13, 3, 38, 486, DateTimeKind.Utc).AddTicks(9734), "Srbija", "Novi Pazar", "Hamza", "Delic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("05d9f29c-dcf5-4034-adf6-3ae0aba0859e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("33d84c84-7a0c-4e5f-9816-3513f354dd16"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("50d7b5f7-8ca0-4425-8881-03fa18dcd5fc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("850ba02c-5af9-4c9b-a9f2-0f903bec689b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a91ef508-098c-4d81-8aba-c2f904004238"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d74fa983-6276-4e07-8adb-cfccca241ff5"));

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
    }
}
