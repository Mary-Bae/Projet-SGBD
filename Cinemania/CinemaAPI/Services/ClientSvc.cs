using Interfaces;
using Models;
using Repositories;

namespace Services
{
    public class ClientSvc : IClientSvc, IClientFilmSvc, IClientCinemaSvc, IClientTraductionSvc
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
         
    }
}
