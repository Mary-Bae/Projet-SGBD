namespace Models
{
    public class ProgrammationAvecNomsDTO
    {
       
        public int pr_id { get; set; }
        public string fi_Nom { get; set; }
        public string ci_Nom { get; set; }
        public DateTime pr_date { get; set; }
    }

    public class ProgrammationTraduitesDTO
    {
        public int pr_id { get; set; }
        public int pt_id { get; set; }
        public string ci_Nom { get; set; }
        public string fi_Nom { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
        public DateTime pr_date { get; set; }
    }
}
