﻿namespace Models
{
    public class FilmsDTO
    {
        public int fi_id { get; set; }
        public string fi_nom { get; set; }
        public string? fi_description { get; set; }
        public string? fi_genre { get; set; }
    }
    public class FilmDTO
    {
        public int fi_id { get; set; }
        public string fi_nom { get; set; }
    }
    public class AjoutFilmsDTO
    {
        public string fi_nom { get; set; }
        public string? fi_description { get; set; }
        public string? fi_genre { get; set; }
    }
}
