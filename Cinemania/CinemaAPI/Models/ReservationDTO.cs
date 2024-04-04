namespace CinemaAPI.Models
{
    public class ReservationDTO
    {
        public int ProjectionId { get; set; }
        public int NbrPersonnes { get; set; }
        public List<Siege> Sieges { get; set; }
    }
    public class Siege
    {
        public int Row { get; set; } // La rangée du siège
        public char SeatNumber { get; set; } // Le numéro du siège dans la rangée
    }
}
