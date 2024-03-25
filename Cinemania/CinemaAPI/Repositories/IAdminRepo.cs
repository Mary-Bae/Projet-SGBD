using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo, ISalleRepo, IFilmRepo, IProgrammationRepo
    {
        Task<List<T>> GetChaine<T>();
        Task DeleteChaine(int pId);
        Task UpdateChaine(int pId, MajChaineDTO pData);
        Task<bool> AjouterChaineCinemaEtSalle(ChaineCinemaEtSalleDTO chaineCinemaEtSalleDTO);

    }
    public interface ICinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int pIdChaine);
        Task DeleteCinemas(int pId);
        Task UpdateCinema(int pId, MajCinemasDTO pData);
        Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO);
    }
    public interface ISalleRepo
    {
        Task<List<T>> GetSalles<T>();
        Task<List<T>> GetSallesByCinema<T>(int pIdCinema);
        Task<SalleDTO> GetSalleBySalleId(int salleId);
        Task DeleteSalle(int pId);
        Task UpdateSalle(int pId, MajSalleDTO pData);
        Task DeleteSallesByCinemaId(int cinemaId);
        Task AddSalle(AjoutSalleDTO pData);
    }
    public interface IFilmRepo
    {
        Task<List<T>> GetFilms<T>();
        Task<FilmsDTO> GetFilmByFilmId(int filmId);
        Task AddFilm(AjoutFilmsDTO pData);
        Task UpdateFilm(int pId, FilmsDTO pData);
    }
    public interface IProgrammationRepo
    {
        Task AddProgrammation(ProgrammationDTO pData);
        Task<List<T>> GetProgrammation<T>();
        Task DeleteProgrammation(int pId);

    }
}
