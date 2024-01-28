using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo
    {
        Task<List<ChaineDTO>> GetChaine();
    }
    public interface ICinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
        Task Delete(int pId);
    }

    //public interface IReservationRepo 
    //{
    //    Task<List<CinemasDTO>> GetCinema3();
    //}
}
