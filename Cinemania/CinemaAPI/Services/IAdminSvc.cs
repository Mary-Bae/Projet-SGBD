using Models;

namespace Interfaces
{
    public interface IAdminSvc
    {
        Task<List<ChaineDTO>> GetCinemaByChaine(string pChaineCinema);
    }
}
