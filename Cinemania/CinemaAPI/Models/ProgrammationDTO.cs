namespace Models
{
    public class AddProgrammationDTO
    {
        public int FilmTraduitId { get; set; }
        public DateTime DateProgrammation { get; set; }
    }
    public class ProgrammationAvecNomsDTO
    {
        public int pr_id { get; set; }
        public string fi_nom { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
        public DateTime pr_date { get; set; }
    }
    public class ProgrammationDTO
    {
        public int pr_id { get; set; }
        public DateTime pr_date { get; set; }
    }
}
