using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TraductionAvecNomsDTO
    {
        public int ft_id { get; set; }
        public string fi_nom { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
    }
    public class TraductionDTO
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public string Langue { get; set; }
        public string SousTitre { get; set; }
    }
    public class AddTraductionDTO
    {
        public int FilmId { get; set; }
        public int LangueId { get; set; }
    }
    public class LangueDTO
    {
        public int la_id { get; set; }
        public string la_langue { get; set; }
        public string la_sousTitre { get; set; }
    }
}
