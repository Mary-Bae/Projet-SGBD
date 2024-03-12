using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo, ISalleRepo
    {
        Task<List<T>> GetChaine<T>();
        Task AddChaine(AjoutChaineDTO pData);
        Task DeleteChaine(int pId);
        Task UpdateChaine(int pId, MajChaineDTO pData);

    }
    public interface ICinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int pIdChaine);
        Task DeleteCinemas(int pId);
        Task UpdateCinema(int pId, MajCinemasDTO pData);
        Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO);
    }
    public interface ISalleRepo
    {
        Task<List<T>> GetSalles<T>();
        Task<List<T>> GetSallesByCinema<T>(int pIdCinema);
        Task<SalleDTO> GetSalleBySalleId(int salleId);
        Task DeleteSalle(int pId);
        Task UpdateSalle(int pId, MajSalleDTO pData);
        Task AddSalle(AjoutSalleDTO pData);
    }
}
