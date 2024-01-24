using Interfaces;
using Models;

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
        public async Task<List<CinemasDTO>> GetCinemaByChaine(string pChaineCinema)
        {
            var lst = await _AdminRepo.GetCinema();

            //IReservationRepo _repoReservation = _AdminRepo;
            //_repoReservation.GetCinema3();
            return lst;
        }
    }
}
