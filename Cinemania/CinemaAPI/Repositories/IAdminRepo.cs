using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo
    {
        //Task<List<ChaineDTO>> GetChaine();
        Task<List<T>> GetChaine<T>();
    }
    public interface ICinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
        Task Delete(int pId);
        Task Update(MajCinemasDTO pData);
    }

    //public interface IReservationRepo 
    //{
    //    Task<List<CinemasDTO>> GetCinema3();
    //}
}
