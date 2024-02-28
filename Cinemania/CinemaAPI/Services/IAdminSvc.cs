using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSvc
    {
        Task<List<T>> GetChaine<T>();
        
    }

    public interface ICinemasSvc
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int chaineId);
        Task Delete(int pId);
        Task Update(MajCinemasDTO pData);
    }
}
