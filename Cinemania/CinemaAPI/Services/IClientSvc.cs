using Models;

namespace Interfaces
{
    public interface IClientSvc : IClientFilmSvc, IClientCinemaSvc, IClientTraductionSvc
    {
    }
    public interface IClientFilmSvc
    {
        Task<List<T>> GetFilms<T>();
        Task<List<T>> GetFilmByCinema<T>(int pCinemaId);
    }
    public interface IClientCinemaSvc
    {
        Task<List<T>> GetCinemas<T>();
    }

    public interface IClientTraductionSvc
    {
        Task<List<T>> GetLanguesByFilmsAndCine<T>(int pCinema, int pFilm);
    }

    
}
