using Interfaces;

namespace Services
{
    public class ClientSvc : IClientSvc
    {
        IClientRepo _clientRepo;
        public ClientSvc(IClientRepo pClientRepo)
        {
            _clientRepo = pClientRepo;
        }
    }
}
