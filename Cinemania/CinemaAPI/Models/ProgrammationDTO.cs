namespace Models
{
    public class ProgrammationDTO
    {
        public int FilmId { get; set; }
        public int CinemaId { get; set; }
        public DateTime DateProgrammation { get; set; }
    }
    public class ProgrammationAvecNomsDTO
    {
        public int pr_id { get; set; }
        public string ci_Nom { get; set; }
        public string fi_Nom { get; set; }
        public DateTime pr_date { get; set; }
    }
}
