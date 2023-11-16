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
    [Migration("20230615181548_dodaliNovuKolonuProfesorima")]
    partial class dodaliNovuKolonuProfesorima
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("STUDENT_API.Models.Profesor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NekaKolona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plata")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professors");
                });

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
                            Id = new Guid("ef3d4ed3-45fb-4e5f-a2ed-bc029c5a10ad"),
                            BrojIndexa = "036011/20",
                            DatumUpisa = new DateTime(2020, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5705),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar",
                            Ime = "Adnan",
                            Prezime = "Crnovrsanin"
                        },
                        new
                        {
                            Id = new Guid("af7e064d-d5e5-404a-ba92-a0e94751544f"),
                            BrojIndexa = "036035/21",
                            DatumUpisa = new DateTime(2021, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5787),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar",
                            Ime = "Mirnesa",
                            Prezime = "Crnovrsanin"
                        },
                        new
                        {
                            Id = new Guid("b8f01366-0eae-4bda-8c51-ff6a727d08c8"),
                            BrojIndexa = "058441/21",
                            DatumUpisa = new DateTime(2021, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5792),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Sad",
                            Ime = "Amina",
                            Prezime = "Hasanovic"
                        },
                        new
                        {
                            Id = new Guid("3e8a663d-c2bc-4c06-9974-1eb8bb1c4852"),
                            BrojIndexa = "038511/20",
                            DatumUpisa = new DateTime(2020, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5795),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Tutin",
                            Ime = "Hasim",
                            Prezime = "Tutic"
                        },
                        new
                        {
                            Id = new Guid("e199f2cb-32fb-4e1d-af50-a9cd20f2f68c"),
                            BrojIndexa = "088711/20",
                            DatumUpisa = new DateTime(2020, 10, 15, 18, 15, 47, 756, DateTimeKind.Utc).AddTicks(5799),
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
