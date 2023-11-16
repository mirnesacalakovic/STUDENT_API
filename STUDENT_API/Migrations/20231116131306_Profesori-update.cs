using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDENT_API.Migrations
{
    public partial class Profesoriupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PIB",
                table: "Professors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BrojIndexa", "DatumUpisa", "DrzavaRodjenja", "GradRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { new Guid("1f0d7f15-ba3a-46f8-b702-c780f38f2fa9"), "036035/21", new DateTime(2022, 3, 16, 13, 13, 6, 571, DateTimeKind.Utc).AddTicks(9962), "Srbija", "Novi Pazar", "Mirnesa", "Crnovrsanin" },
                    { new Guid("7eae7b7d-4a69-4c46-a2ce-233a9af06075"), "058441/21", new DateTime(2022, 3, 16, 13, 13, 6, 571, DateTimeKind.Utc).AddTicks(9964), "Srbija", "Novi Sad", "Amina", "Hasanovic" },
                    { new Guid("993d16fd-5da7-4c35-9bdb-0daf9af55b9b"), "088711/20", new DateTime(2021, 3, 16, 13, 13, 6, 571, DateTimeKind.Utc).AddTicks(9985), "ASajd", "Novi Sad", "ne znam", "Mirbejnd" },
                    { new Guid("e0551873-a1ef-442e-bd03-915ddf55b067"), "088711/20", new DateTime(2021, 3, 16, 13, 13, 6, 571, DateTimeKind.Utc).AddTicks(9968), "Srbija", "Novi Pazar", "Hamza", "Delic" },
                    { new Guid("eed1ea16-dd9c-4391-9415-ebc6e30e9dab"), "036011/20", new DateTime(2021, 3, 16, 13, 13, 6, 571, DateTimeKind.Utc).AddTicks(9946), "Srbija", "Novi Pazar", "Adnan", "Crnovrsanin" },
                    { new Guid("fd5e1cdc-1e44-4db7-9f6d-189757fc44c3"), "038511/20", new DateTime(2021, 3, 16, 13, 13, 6, 571, DateTimeKind.Utc).AddTicks(9966), "Srbija", "Tutin", "Hasim", "Tutic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1f0d7f15-ba3a-46f8-b702-c780f38f2fa9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7eae7b7d-4a69-4c46-a2ce-233a9af06075"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("993d16fd-5da7-4c35-9bdb-0daf9af55b9b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e0551873-a1ef-442e-bd03-915ddf55b067"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("eed1ea16-dd9c-4391-9415-ebc6e30e9dab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fd5e1cdc-1e44-4db7-9f6d-189757fc44c3"));

            migrationBuilder.DropColumn(
                name: "PIB",
                table: "Professors");

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
    }
}
