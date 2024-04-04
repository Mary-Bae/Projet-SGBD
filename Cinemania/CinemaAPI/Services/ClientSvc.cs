using Interfaces;
using Models;
using Repositories;

namespace Services
{
    public class ClientSvc : IClientSvc, IClientFilmSvc, IClientCinemaSvc, IClientTraductionSvc, IClientDatesSvc,
        IClientSalleSvc, IClientReservationSvc
    {
        IClientRepo _clientRepo;
        public ClientSvc(IClientRepo pClientRepo)
        {
            _clientRepo = pClientRepo;
        }

        //Films
        async Task<List<T>> IClientFilmSvc.GetFilms<T>()
        {
            IClientFilmRepo filmRepo = _clientRepo;
            var lst = await filmRepo.GetFilms<T>();
            return lst.ToList<T>();
        }

        public async Task<List<T>> GetFilmByCinema<T>(int pId)
        {
            return await _clientRepo.GetFilmByCinema<T>(pId);
        }

        //Cinemas
        async Task<List<T>> IClientCinemaSvc.GetCinemas<T>()
        {
            IClientCinemaRepo cinemasRepo = _clientRepo;
            var lst = await cinemasRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }

        //Traductions
        async Task<List<T>> IClientTraductionSvc.GetLanguesByFilmsAndCine<T>(int pCinema, int pFilm)
        {
            return await _clientRepo.GetLanguesByFilmsAndCine<T>(pCinema, pFilm);
        }

        // Dates
        async Task<DatesDTO> IClientDatesSvc.GetDatesByProjection(int filmId, int cinemaId, int langueId, string horaire)
        {
            return await _clientRepo.GetDatesByProjection(filmId, cinemaId, langueId, horaire);
        }

        //Salle
        async Task<SalleDTO> IClientSalleSvc.GetSalleByProjection(SalleByProjectionDTO pSalle, DateTime pDate)
        {
            return await _clientRepo.GetSalleByProjection(pSalle, pDate);
        }

        //Reservation
        public async Task<bool> AddReservation(ReservationDTO reservation)
        {
            return await _clientRepo.AddReservation(reservation);
        }
    }
}
