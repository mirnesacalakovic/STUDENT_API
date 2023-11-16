﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STUDENT_API;

#nullable disable

namespace STUDENT_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230615174828_DodaliSmoStudente")]
    partial class DodaliSmoStudente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("STUDENT_API.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrojIndexa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumUpisa")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrzavaRodjenja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GradRodjenja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("590fe852-1e90-488b-9dac-9f399ac224a0"),
                            BrojIndexa = "036011/20",
                            DatumUpisa = new DateTime(2020, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6441),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar",
                            Ime = "Adnan",
                            Prezime = "Crnovrsanin"
                        },
                        new
                        {
                            Id = new Guid("b3377045-96c2-464a-a315-67675fadab01"),
                            BrojIndexa = "036035/21",
                            DatumUpisa = new DateTime(2021, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6466),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar",
                            Ime = "Mirnesa",
                            Prezime = "Crnovrsanin"
                        },
                        new
                        {
                            Id = new Guid("76295bb0-6f4f-4412-8c32-2f538ba43e93"),
                            BrojIndexa = "058441/21",
                            DatumUpisa = new DateTime(2021, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6474),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Sad",
                            Ime = "Amina",
                            Prezime = "Hasanovic"
                        },
                        new
                        {
                            Id = new Guid("a8337fae-2f75-4f41-bde3-32318592053a"),
                            BrojIndexa = "038511/20",
                            DatumUpisa = new DateTime(2020, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6480),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Tutin",
                            Ime = "Hasim",
                            Prezime = "Tutic"
                        },
                        new
                        {
                            Id = new Guid("9b124230-d629-4fc4-b106-a17892b04056"),
                            BrojIndexa = "088711/20",
                            DatumUpisa = new DateTime(2020, 10, 15, 17, 48, 27, 721, DateTimeKind.Utc).AddTicks(6487),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar",
                            Ime = "Hamza",
                            Prezime = "Delic"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
