using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIClient;

namespace Models
{
    public class ReservationDetailsDTO
    {
        public int CinemaId { get; set; }
        public string CinemaNom { get; set; }
        public int FilmId { get; set; }
        public string FilmNom { get; set; }
        public int LangueId { get; set; }
        public string Horaire { get; set; }
        public DateTime DateSelectionnee { get; set; }
        public SalleDTO SalleDetails { get; set; }
        public int ChaineId { get; set; }
    }

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
        public int Row { get; set; }
        public int SeatNumber { get; set; }
    }
    public class DateReserveeDTO
    {
        public int ProjectionId { get; set; }
        public DateTime Date { get; set; }
    }

}
