using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSvc, ISalleSvc
    {
        Task<List<T>> GetChaine<T>();
        Task AddChaine(AjoutChaineDTO ajoutChaine);
        Task DeleteChaine(int pId);
        Task UpdateChaine(int pId, MajChaineDTO majChaine);

    }
    public interface ICinemasSvc
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int pIdChaine);
        Task DeleteCinemas(int pId);
        Task UpdateCinema(int pId, MajCinemasDTO MajCinemas);
        Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO);
    }
    public interface ISalleSvc
    {
        Task<List<T>> GetSalles<T>();
        Task<List<T>> GetSallesByCinema<T>(int pIdCinema);
        Task<SalleDTO> GetSalleBySalleId(int salleId);
        Task DeleteSalle(int pId);
        Task UpdateSalle(int pId, MajSalleDTO MajSalle);
        Task AddSalle(AjoutSalleDTO ajoutSalle);
 
    }
}
