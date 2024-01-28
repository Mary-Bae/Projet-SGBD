namespace Models
{
    public class CinemasDTO
    {
        public int CINE_ID { get; set; }
        public string? CINE_Nom { get; set; }
        public string? CINE_Adresse { get; set; }
        public int? CINE_NbrSalles { get; set; }
    }

    public class MajCinemasDTO
    {
        public int CINE_ID { get; set; }
        public string? CINE_Nom { get; set; }
        public int? CINE_NbrSalles { get; set; }
    }
}
