namespace Models
{
    public class ReservationDTO
    {
        public int ProjectionId { get; set; }
        public int NbrPersonnes { get; set; }
        public List<SiegeDTO> Sieges { get; set; }
        public DateTime DateReservee { get; set; }
        public string? UidAbonnement { get; set; }
        public int ChaineId { get; set; }
    }
    public class SiegeDTO
    {
        public int Row { get; set; } // La rangée du siège
        public int SeatNumber { get; set; } // Le numéro du siège dans la rangée
    }
    public class DateReserveeDTO
    {
        public int ProjectionId { get; set; }
        public DateTime Date { get; set; }
    }
}
