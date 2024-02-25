using Interfaces;
using Models;

namespace Services
{
    public class AdminSvc : IAdminSvc, ICinemasSvc
    {
        IAdminRepo _adminRepo;
        public AdminSvc(IAdminRepo pAdminRepo)
        {
            _adminRepo = pAdminRepo;
        }
        public async Task<List<ChaineDTO>> GetCinemaByChaine(string pChaineCinema)
        {
            var lst = await _adminRepo.GetChaine();

            //IReservationRepo _repoReservation = _AdminRepo;
            //_repoReservation.GetCinema3();
            return lst;
        }

        async Task<List<T>> ICinemasSvc.GetCinemas<T>()
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            var lst = await cinemasRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }
        async Task ICinemasSvc.Delete(int pId)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.Delete(pId);
        }
        async Task ICinemasSvc.Update(MajCinemasDTO pData)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.Update(pData);
        }
    }
}
