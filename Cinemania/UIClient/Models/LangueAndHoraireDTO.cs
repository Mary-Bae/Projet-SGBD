namespace Models
{
    public class LangueAndHoraireDTO
    {
        public int la_id { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
        public string se_horaire { get; set; }
        public DateTime pr_date { get; set; }
        public DateTime se_dateFin { get; set; }
    }
}
