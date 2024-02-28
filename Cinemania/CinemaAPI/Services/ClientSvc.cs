using Interfaces;
using Repositories;

namespace Services
{
    public class ClientSvc : IClientSvc
    {
        IClientRepo _clientRepo;
        public ClientSvc(IClientRepo pClientRepo)
        {
            _clientRepo = pClientRepo;
        }
        async Task<List<T>> IClientSvc.GetCinemas<T>()
        {
            IClientRepo clientRepo = _clientRepo;
            var lst = await clientRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }
    }
}
