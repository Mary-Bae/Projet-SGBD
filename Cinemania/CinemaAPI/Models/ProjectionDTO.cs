namespace Models
{
    public class ProjectionDTO
    {
        public int pro_id { get; set; }
        public string ci_nom { get; set; }
        public int sa_numeroSalle { get; set; }
        public string fi_nom { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
        public string se_horaire { get; set; }
        public DateTime pr_date { get; set; }
        public DateTime se_dateFin { get; set; }
    }

    public class AddProjectionDTO
    {
        public int SeanceId { get; set; }
        public int SalleId { get; set; }
    }
}
