using Models;

namespace Interfaces
{
    public interface IClientSvc : IClientFilmSvc, IClientCinemaSvc, IClientTraductionSvc, IClientDatesSvc, IClientSalleSvc,
        IClientReservationSvc, IClientChaineSvc, IClientAbonnementSvc
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
        Task<List<T>> GetCinemasByChaine<T>(int pIdChaine);
    }

    public interface IClientTraductionSvc
    {
        Task<List<T>> GetLanguesByFilmsAndCine<T>(int pCinema, int pFilm);
    }
    public interface IClientDatesSvc
    {
        Task<DatesDTO?> GetDatesByProjection(int filmId, int cinemaId, int langueId, string horaire);
    }
    public interface IClientSalleSvc
    {
        Task<SalleDTO> GetSalleByProjection(SalleByProjectionDTO pSalle, DateTime pDate);
    }
    public interface IClientReservationSvc
    {
        Task<bool> AddReservation(ReservationDTO reservation);
        Task<bool> AddReservationWithAbonnement(ReservationDTO reservation);
        Task<List<SiegeDTO>> SiegesReservesByProjection(int projectionId, DateTime date);
    }
    public interface IClientChaineSvc
    {
        Task<List<T>> GetChaine<T>();
    }
    public interface IClientAbonnementSvc
    {
        Task<AbonnementInfosDTO?> AddAbonnement(int chaineId);
        Task<int> GetPlacesRestantes(string uidAbonnement);
    }


}
