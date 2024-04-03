using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ReservationDetailsDTO
    {
        public int CinemaId { get; set; }
        public string CinemaNom { get; set; }
        public int FilmId { get; set; }
        public int LangueId { get; set; }
        public string Horaire { get; set; }
        public DateTime DateSelectionnee { get; set; }
        public SalleDTO SalleDetails { get; set; }
    }
}
