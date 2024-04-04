namespace Models
{
    public class ReservationDTO
    {
        public int ProjectionId { get; set; }
        public int NbrPersonnes { get; set; }
        public List<SiegeDTO> Sieges { get; set; }
    }
    public class SiegeDTO
    {
        public int Row { get; set; } // La rangée du siège
        public int SeatNumber { get; set; } // Le numéro du siège dans la rangée
    }
}
