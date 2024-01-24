using Models;

namespace Interfaces
{
    public interface IAdminRepo
    {
        Task<List<CinemasDTO>> GetCinema();
    }
}
