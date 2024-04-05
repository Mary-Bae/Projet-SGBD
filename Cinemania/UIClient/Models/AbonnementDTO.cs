namespace Models
{
    public class AbonnementDTO
    {
        public int ChaineId { get; set; }
        public string Uid { get; set; }
        public DateTime DateAchat { get; set; }
        public DateTime DateFinValidite { get; set; }
    }
    public class AbonnementInfosDTO
    {
        public string Uid { get; set; }
        public DateTime DateAchat { get; set; }
        public DateTime DateFinValidite { get; set; }
    }
}
