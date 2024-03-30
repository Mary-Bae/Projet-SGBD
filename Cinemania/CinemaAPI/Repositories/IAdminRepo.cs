using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;

namespace Interfaces
{
    public interface IAdminRepo : ICinemaRepo, ISalleRepo, IFilmRepo, IProgrammationRepo,
        ITraductionRepo, IProgrammationTraduitRepo, ISeanceRepo
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
        Task DeleteFilm(int pId);
    }
    public interface IProgrammationRepo
    {
        Task AddProgrammation(ProgrammationDTO pData);
        Task<List<T>> GetProgrammationByFilm<T>(int pFilm);
        Task DeleteProgrammation(int pId);

    }
    public interface ITraductionRepo
    {
        Task<List<T>> GetLangues<T>();
        Task<List<T>> GetFilmTraduitByFilm<T>(int pIdFilm);
        Task<List<T>> GetFilmTraduitByProgrammation<T>(int pIdProgrammation);
        Task AddTraduction(AddTraductionDTO pData);
        Task DeleteTraduction(int pId);
    }
    public interface IProgrammationTraduitRepo
    {
        Task AddProgrammationTraduit(ProgrammationTraduiteDTO pData);
        Task DeleteFilmTraduit(int pId);
        Task<List<T>> GetProgrammationTraduit<T>();
    }

    public interface ISeanceRepo
    {
        Task AddSeance(AddSeanceDTO pData);
    }
}
