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

        public async Task AddChaine(AjoutChaineDTO ajoutChaineDTO)
        {
            await _adminRepo.AddChaine(ajoutChaineDTO);
        }
        async Task IAdminSvc.DeleteChaine(int pId)
        {
            IAdminRepo adminRepo = _adminRepo;
            await adminRepo.DeleteChaine(pId);
        }
        public async Task<List<T>> GetCinemasByChaine<T>(int chaineId)
        {
            return await _adminRepo.GetCinemasByChaine<T>(chaineId);
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
        async Task ICinemasSvc.Update(MajCinemasDTO pData)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.Update(pData);
        }
    }
}
