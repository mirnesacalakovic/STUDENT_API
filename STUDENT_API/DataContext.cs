using Microsoft.EntityFrameworkCore;
using STUDENT_API.Models;

namespace STUDENT_API
{ //8.klasa DataContext nasledjuje DbCondext
    //DbContext - klasa koju nam daje entity framework koja nam dozvoljava i daje alate da radimo sa bazom (punomocje)
    public class DataContext : DbContext
    { //9.pravimo dva konstruktora, sa i bez paarmetara (ctrl i . olaksava generate...)
        
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //ova mora da je public
        public DataContext()
        {
        }
        //10.ctrl . => generate overrides => deselect all  => cekiramo OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder) //funkcija koja se poziva kad se kreira baza
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasData(
                    new List<Student>
                    {
                        new Student
                        {
                            Id = Guid.NewGuid(),
                            Ime = "Adnan",
                            Prezime = "Crnovrsanin",
                            BrojIndexa = "036011/20",
                            DatumUpisa = DateTime.UtcNow.AddYears(-3).AddMonths(+4),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar"
                        },
                         new Student
                        {
                             Id = Guid.NewGuid(),
                            Ime = "Mirnesa",
                            Prezime = "Crnovrsanin",
                            BrojIndexa = "036035/21",
                            DatumUpisa = DateTime.UtcNow.AddYears(-2).AddMonths(+4),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar"
                        },
                          new Student
                        {
                            Id= Guid.NewGuid(),
                            Ime = "Amina",
                            Prezime = "Hasanovic",
                            BrojIndexa = "058441/21",
                            DatumUpisa = DateTime.UtcNow.AddYears(-2).AddMonths(+4),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Sad"
                        },
                           new Student
                        {
                            Id= Guid.NewGuid(),
                            Ime = "Hasim",
                            Prezime = "Tutic",
                            BrojIndexa = "038511/20",
                            DatumUpisa = DateTime.UtcNow.AddYears(-3).AddMonths(+4),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Tutin"
                        },
                            new Student
                        {
                            Id= Guid.NewGuid(),
                            Ime = "Hamza",
                            Prezime = "Delic",
                            BrojIndexa = "088711/20",
                            DatumUpisa = DateTime.UtcNow.AddYears(-3).AddMonths(+4),
                            DrzavaRodjenja = "Srbija",
                            GradRodjenja = "Novi Pazar"
                        },
                            new Student
                        {
                            Id= Guid.NewGuid(),
                            Ime = "ne znam",
                            Prezime = "Mirbejnd",
                            BrojIndexa = "088711/20",
                            DatumUpisa = DateTime.UtcNow.AddYears(-3).AddMonths(+4),
                            DrzavaRodjenja = "ASajd",
                            GradRodjenja = "Novi Sad"
                        }
                    }
                 ) ;
            
        }
        //11. dodavanje properties i
        //12. include STUDENT_API.Models (gde su nam modeli)
        public DbSet<Student> Students { get; set; } //ime je praksa da bude mnozina od klase koja je u <***>
        //sa ovom linijom koda smo rekli builderu da napravi tabelu od ove klase
        //13. dodali smo gore ove podatke kako bi imali nesto da radimo sa bazom

        public DbSet<Profesor> Professors { get; set; }

    }
}
