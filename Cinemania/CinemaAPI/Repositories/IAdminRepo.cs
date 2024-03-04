using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo
    {
        Task<List<T>> GetChaine<T>();
        Task AddChaine(AjoutChaineDTO pData);
        Task DeleteChaine(int pId);
        Task UpdateChaine(int pId, MajChaineDTO pData);

    }
    public interface ICinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int pId);
        Task DeleteCinemas(int pId);
        Task UpdateCinema(int pId, MajCinemasDTO pData);
        Task AddCinema(AjoutCinemasDTO pData);
    }

    //public interface IReservationRepo 
    //{
    //    Task<List<CinemasDTO>> GetCinema3();
    //}
}
