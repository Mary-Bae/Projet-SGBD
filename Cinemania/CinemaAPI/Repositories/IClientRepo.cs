
using Models;

namespace Interfaces
{
    public interface IClientRepo : IClientFilmRepo, IClientCinemaRepo, IClientTraductionRepo, IClientDatesRepo
    {
    }
    public interface IClientFilmRepo
    {
        Task<List<T>> GetFilms<T>();
        Task<List<T>> GetFilmByCinema<T>(int pCinemaId);
    }
    public interface IClientCinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
    }
    public interface IClientTraductionRepo
    {
        Task<List<T>> GetLanguesByFilmsAndCine<T>(int pCinema, int pFilm);
    }
    public interface IClientDatesRepo
    {
        Task<DatesDTO> GetDatesByProjection(int filmId, int cinemaId, int langueId, string horaire);
    }
}
