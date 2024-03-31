namespace Models
{
    public class AddSeanceDTO
    {
        public string  se_horaire { get; set; }
        public DateTime se_dateFin { get; set; }
        public int se_pr_id { get; set; }
    }

    public class SeanceDTO
    {
        public int se_id { get; set; }
        public string fi_nom { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
        public string se_horaire { get; set; }
        public DateTime pr_date { get; set; }
        public DateTime se_dateFin { get; set; }
    }
}
