using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSvc
    {
        Task<List<ChaineDTO>> GetCinemaByChaine(string pChaineCinema);
    }

    public interface ICinemasSvc
    {
        Task<List<T>> GetCinemas<T>();
        Task Delete(int pId);
        Task Update(MajCinemasDTO pData);
    }
}
