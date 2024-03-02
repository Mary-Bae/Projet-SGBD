using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo
    {
        Task<List<T>> GetChaine<T>();
        Task AddChaine(AjoutChaineDTO ajoutChaineDTO);
        Task DeleteChaine(int pId);

    }
    public interface ICinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int chaineId);
        Task DeleteCinemas(int pId);
        Task Update(MajCinemasDTO pData);
    }

    //public interface IReservationRepo 
    //{
    //    Task<List<CinemasDTO>> GetCinema3();
    //}
}
