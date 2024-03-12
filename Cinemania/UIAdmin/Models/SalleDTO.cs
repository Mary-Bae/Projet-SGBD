
namespace Models
{
    public class SalleDTO
    {
        public int sa_id { get; set; }
        public int sa_numeroSalle { get; set; }
        public int sa_qtePlace { get; set; }
        public int sa_qteRangees { get; set; }
        public int sa_ci_id { get; set; }
    }
    public class AjoutSalleDTO
    {
        public int sa_qteRangees { get; set; }
        public int sa_qtePlace { get; set; }
        public int sa_qtePlace_Rangee { get; set; }
        public int sa_numeroSalle { get; set; }
        public int sa_ci_id { get; set; }
    }
    public class MajSalleDTO
    {
        public int sa_id { get; set; }
        public int sa_qteRangees { get; set; }
        public int sa_qtePlace { get; set; }
        public int sa_qtePlace_Rangee { get; set; }
        public int sa_numeroSalle { get; set; }
        public int sa_ci_id { get; set; }
    }
}
