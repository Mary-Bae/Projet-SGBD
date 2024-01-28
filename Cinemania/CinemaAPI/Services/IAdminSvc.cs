using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSVC
    {
        Task<List<ChaineDTO>> GetCinemaByChaine(string pChaineCinema);
    }

    public interface ICinemasSVC
    {
        Task<List<T>> GetCinemas<T>();
        Task Delete(int pId);
    }
}
