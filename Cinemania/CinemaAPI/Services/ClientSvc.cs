using Interfaces;
using Repositories;

namespace Services
{
    public class ClientSvc : IClientSvc, IClientFilmSvc, IClientCinemaSvc
    {
        IClientRepo _clientRepo;
        public ClientSvc(IClientRepo pClientRepo)
        {
            _clientRepo = pClientRepo;
        }
        async Task<List<T>> IClientFilmSvc.GetFilms<T>()
        {
            IClientFilmRepo filmRepo = _clientRepo;
            var lst = await filmRepo.GetFilms<T>();
            return lst.ToList<T>();
        }
        async Task<List<T>> IClientCinemaSvc.GetCinemas<T>()
        {
            IClientCinemaRepo cinemasRepo = _clientRepo;
            var lst = await cinemasRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }
    }
}
