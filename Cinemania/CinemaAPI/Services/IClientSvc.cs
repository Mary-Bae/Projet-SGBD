using Models;

namespace Interfaces
{
    public interface IClientSvc : IClientFilmSvc, IClientCinemaSvc, IClientTraductionSvc, IClientDatesSvc, IClientSalleSvc,
        IClientReservationSvc
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
    public interface IClientDatesSvc
    {
        Task<DatesDTO> GetDatesByProjection(int filmId, int cinemaId, int langueId, string horaire);
    }
    public interface IClientSalleSvc
    {
        Task<SalleDTO> GetSalleByProjection(SalleByProjectionDTO pSalle, DateTime pDate);
    }
    public interface IClientReservationSvc
    {
        Task<bool> AddReservation(ReservationDTO reservation);
        Task<List<SiegeDTO>> SiegesReservesByProjection(int projectionId, DateTime date);
    }


}
