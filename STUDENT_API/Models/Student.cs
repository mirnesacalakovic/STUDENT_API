namespace STUDENT_API.Models
{
    //ova klasa mora ima neke properties (nasa tabela student u bazi)
    public class Student
    {
        //treba nam id tipa guid (globalni unique indetifajer)
        public Guid Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndexa { get; set; }
        public DateTime DatumUpisa { get; set; }
        public string DrzavaRodjenja { get; set; }
        public string GradRodjenja { get; set; }

        //7.posle definisanja propertiesa pravimo globalnu klasu dataContext i ta klasa omogucava konekciju sa bazom
    }
}
