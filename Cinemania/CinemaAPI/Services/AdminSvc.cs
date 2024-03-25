using Interfaces;
using Models;

namespace Services
{
    public class AdminSvc : IAdminSvc, ICinemasSvc, ISalleSvc, IFilmSvc, IProgrammationSvc
    {
        IAdminRepo _adminRepo;
        public AdminSvc(IAdminRepo pAdminRepo)
        {
            _adminRepo = pAdminRepo;
        }

        // chaine de cinema
        async Task<List<T>> IAdminSvc.GetChaine<T>()
        {
            IAdminRepo adminRepo = _adminRepo;
            var lst = await adminRepo.GetChaine<T>();
            return lst.ToList<T>();
        }

        public async Task<bool> AjouterChaineCinemaEtSalle(ChaineCinemaEtSalleDTO chaineCinemaEtSalleDTO)
        {
            return await _adminRepo.AjouterChaineCinemaEtSalle(chaineCinemaEtSalleDTO);
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

        // Cinema
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

        // Salles de cinema

        public async Task<List<T>> GetSallesByCinema<T>(int pId)
        {
            return await _adminRepo.GetSallesByCinema<T>(pId);
        }
        public async Task<SalleDTO> GetSalleBySalleId(int salleId)
        {
            ISalleRepo salleRepo = _adminRepo;
            var salle = await salleRepo.GetSalleBySalleId(salleId);

            if (salle != null)
            {
                return new SalleDTO
                {
                    sa_id = salle.sa_id,
                    sa_numeroSalle = salle.sa_numeroSalle,
                    sa_qteRangees = salle.sa_qteRangees,
                    sa_qtePlace = salle.sa_qtePlace,
                    sa_qtePlace_Rangee= salle.sa_qtePlace_Rangee,
                    sa_ci_id= salle.sa_ci_id
                };
            }

            return null; // Ou gérer autrement si la salle n'est pas trouvée
        }
        async Task<List<T>> ISalleSvc.GetSalles<T>()
        {
            ISalleRepo salleRepo = _adminRepo;
            var lst = await salleRepo.GetSalles<T>();
            return lst.ToList<T>();
        }
        async Task ISalleSvc.AddSalle(AjoutSalleDTO pData)
        {
            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.AddSalle(pData);
        }

        public async Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO)
        {
            return await _adminRepo.AjouterCinemaEtSalle(cinemaEtSalleDTO);
        }
        async Task ISalleSvc.DeleteSalle(int pId)
        {
            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.DeleteSalle(pId);
        }
        public async Task DeleteSallesByCinemaId(int cinemaId)
        {
            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.DeleteSallesByCinemaId(cinemaId);
        }

        async Task ISalleSvc.UpdateSalle(int pId, MajSalleDTO pData)
        {
            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.UpdateSalle(pId, pData);
        }

        // Films

        async Task<List<T>> IFilmSvc.GetFilms<T>()
        {
            IFilmRepo filmRepo = _adminRepo;
            var lst = await filmRepo.GetFilms<T>();
            return lst.ToList<T>();
        }

        // Programmation

        async Task IProgrammationSvc.AddProgrammation(ProgrammationDTO pData)
        {
            IProgrammationRepo programmationRepo = _adminRepo;
            await programmationRepo.AddProgrammation(pData);
        }
        async Task<List<T>> IProgrammationSvc.GetProgrammation<T>()
        {
            IProgrammationRepo programmationRepo = _adminRepo;
            var lst = await programmationRepo.GetProgrammation<T>();
            return lst.ToList<T>();
        }
        async Task IProgrammationSvc.DeleteProgrammation(int pId)
        {
            IProgrammationRepo programmationRepo = _adminRepo;
            await programmationRepo.DeleteProgrammation(pId);
        }
    }
}
