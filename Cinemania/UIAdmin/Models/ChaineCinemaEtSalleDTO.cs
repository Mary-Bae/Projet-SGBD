namespace Models
{
    public class ChaineCinemaEtSalleDTO
    {
        // Chaine de cinéma
        public string NomChaine { get; set; }

        // Cinéma
        public string NomCinema { get; set; }
        public string AdresseCinema { get; set; }

        // Salle
        public int NumeroSalle { get; set; }
        public int QteRangees { get; set; }
        public int QtePlace { get; set; }
        public int QtePlacesRangee { get; set; }
    }
}
