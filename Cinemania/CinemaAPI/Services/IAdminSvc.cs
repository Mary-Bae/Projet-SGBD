using Models;

namespace Interfaces
{
    public interface IAdminSvc
    {
        Task<List<CinemasDTO>> GetCinemaByChaine(string pChaineCinema);
    }
}
