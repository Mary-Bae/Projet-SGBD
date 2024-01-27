using Models;

namespace Interfaces
{
    public interface IAdminRepo //: IReservationRepo, ICinemaRepo
    {
        Task<List<ChaineDTO>> GetChaine();
    }

    //public interface ICinemaRepo
    //{
    //    Task<List<CinemasDTO>> GetCinema2();
    //}

    //public interface IReservationRepo 
    //{
    //    Task<List<CinemasDTO>> GetCinema3();
    //}
}
