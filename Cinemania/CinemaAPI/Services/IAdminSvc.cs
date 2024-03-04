using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSvc
    {
        Task<List<T>> GetChaine<T>();
        Task AddChaine(AjoutChaineDTO ajoutChaine);
        Task DeleteChaine(int pId);
        Task UpdateChaine(int pId, MajChaineDTO majChaine);

    }
    public interface ICinemasSvc
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int chaineId);
        Task DeleteCinemas(int pId);
        Task UpdateCinema(int pId, MajCinemasDTO MajCinemas);
        Task AddCinema(AjoutCinemasDTO ajoutCinemas);
    }
}
