using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STUDENT_API.Models;

namespace STUDENT_API.Controllers
{ //u ovoj klasi ce da budu svi nasi kontroleri koji su namenjeni za studenta
    //svaka klasa za Controllere nasledjuje klasu CONTOLLER_BASE

    //1.kad nasledim klasu treba mi 2.anotacija (opisujemo za sistem sta ona radi) i ona je u uglastim zagradama
    [ApiController]    //rekli smo sistemu da je ovo api kontoler sto pravimo 
    [Route("[controller]")]  //route (rekli smo sistemu koja je bazicna ruta za ovaj skup! kontolera) (bazicni url)
    public class StudentController : ControllerBase
    {
        //20 i nekki (posle migracija) dodali konstruktor i kao parametre ima (DataContext context) i napravili readonly prop koji namtreba za komunikaciju sa bazom
        //posle ovoga prelazimoooooo na ono sto nam pravi error IActionResult (tip onoga sto returna funkcija)
        private readonly DataContext context;

        public StudentController(DataContext context)
        {
            this.context = context;
        }
        
        //3.napravicmo funkciju koja ce da se zove GETALLSTUDENTS i povratni tip SVAKOG KONTROLERA je IActionResult
        //4.posle ovog koraka pravimo kontakt sa bazom : otvaaramo sql server i konektujemo ga sa desktopom


        //da bi ova funkcija dole radila moramo da dodamo anotaciju gde ubacujemo metodu i rutu (naziv) za koju je vezana (koji dodajemo na bazicnu rutu)
        [HttpGet("sviStudenti")]
        public async Task<IActionResult> GetAllStudentsAsync ()
        {
            //5.trebaju mi dve biblioteke i odem na nuget packages, intaliram entityframework.design i entityframeworkCore.SqlServer i cekiram da ga intaliram u  moj API
            //6.pravim folder Models i unutra ubacujemo modele i tu pravimo klasu student
            var students = await context.Students.ToListAsync();  //posle await izbrisemo async koje on doda i  dodamo ctl . -> make method async i on to vrapa u task

            if (students == null)
                return NotFound();

            return Ok(students);
        }

        [HttpPost("dodajStudenta")]
        public async Task<IActionResult> AddStudentsAsync(Student newStudent)
        {
            var student = new Student
            {
                BrojIndexa = newStudent.BrojIndexa,
                Ime = newStudent.Ime,
                Prezime = newStudent.Prezime,
                DatumUpisa = newStudent.DatumUpisa,
                DrzavaRodjenja = newStudent.DrzavaRodjenja,
                GradRodjenja = newStudent.GradRodjenja,
            };

            context.Students.Add(student); //students - ime table u bazi

            await context.SaveChangesAsync();

            return Ok(student);
        }
    }
}
