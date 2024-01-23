using Interfaces;

namespace Services
{
    public class AdminSvc : IAdminSvc
    {
        IAdminRepo _AdminRepo;
        IClientRepo _ClientRepo;
        public AdminSvc(IAdminRepo pAdminRepo, IClientRepo pClientRepo)
        {
            _AdminRepo = pAdminRepo;
            _ClientRepo = pClientRepo;
        }
        public async Task<List<string>> GetCinemaByChaine(string pChaineCinema)
        {
            List<string> list = new List<string>();
            var lst = _AdminRepo.GetCinema();
            return list;
        }
    }
}
