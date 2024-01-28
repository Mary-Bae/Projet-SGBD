using Interfaces;
using Models;

namespace Services
{
    public class AdminSvc : IAdminSvc, ICinemasSVC
    {
        IAdminRepo _AdminRepo;
        IClientRepo _ClientRepo;
        public AdminSvc(IAdminRepo pAdminRepo, IClientRepo pClientRepo)
        {
            _AdminRepo = pAdminRepo;
            _ClientRepo = pClientRepo;
        }
        public async Task<List<ChaineDTO>> GetCinemaByChaine(string pChaineCinema)
        {
            var lst = await _AdminRepo.GetChaine();

            //IReservationRepo _repoReservation = _AdminRepo;
            //_repoReservation.GetCinema3();
            return lst;
        }

        async Task<List<T>> ICinemasSVC.GetCinemas<T>()
        {
            ICinemaRepo cinemasRepo = _AdminRepo;
            var lst = await cinemasRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }
        async Task ICinemasSVC.Delete(int pId)
        {
            ICinemaRepo cinemasRepo = _AdminRepo;
            await cinemasRepo.Delete(pId);
        }
    }
}
