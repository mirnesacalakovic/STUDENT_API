namespace STUDENT_API.Models
{
    //MODELI IMAJU SAMO PROPERTIES
    public class Profesor
    {
        public Guid Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Plata { get; set; }
        public string JMBG { get; set; }
        public int PIB { get; set; }
    }
}
