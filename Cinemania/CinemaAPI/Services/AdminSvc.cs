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

        async Task<List<T>> IAdminSvc.GetChaine<T>()
        {
            IAdminRepo adminRepo = _adminRepo;
            var lst = await adminRepo.GetChaine<T>();
            return lst.ToList<T>();
        }

        public async Task AddChaine(AjoutChaineDTO pData)
        {
            await _adminRepo.AddChaine(pData);
        }
        async Task IAdminSvc.DeleteChaine(int pId)
        {
            IAdminRepo adminRepo = _adminRepo;
            await adminRepo.DeleteChaine(pId);
        }

        public Task UpdateChaine(int pId, MajChaineDTO pData)
        {
            return _adminRepo.UpdateChaine(pId, pData);
        }

        public async Task<List<T>> GetCinemasByChaine<T>(int pId)
        {
            return await _adminRepo.GetCinemasByChaine<T>(pId);
        }

        async Task<List<T>> ICinemasSvc.GetCinemas<T>()
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            var lst = await cinemasRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }
        async Task ICinemasSvc.DeleteCinemas(int pId)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.DeleteCinemas(pId);
        }
        async Task ICinemasSvc.UpdateCinema(int pId, MajCinemasDTO pData)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.UpdateCinema(pId, pData);
        }
        async Task ICinemasSvc.AddCinema(AjoutCinemasDTO pData)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.AddCinema(pData);
        }
    }
}
