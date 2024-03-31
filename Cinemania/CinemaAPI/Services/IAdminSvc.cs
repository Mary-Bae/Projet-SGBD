using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSvc, ISalleSvc, IFilmSvc, IProgrammationSvc,
        ITraductionSvc, ISeanceSvc, IProjectionSvc
    {
        Task<List<T>> GetChaine<T>();
        Task DeleteChaine(int pId);
        Task UpdateChaine(int pId, MajChaineDTO majChaine);
        Task<bool> AjouterChaineCinemaEtSalle(ChaineCinemaEtSalleDTO chaineCinemaEtSalleDTO);

    }
    public interface ICinemasSvc
    {
        Task<List<T>> GetCinemas<T>();
        Task<List<T>> GetCinemasByChaine<T>(int pIdChaine);
        Task DeleteCinemas(int pId);
        Task UpdateCinema(int pId, MajCinemasDTO MajCinemas);
        Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO);
    }
    public interface ISalleSvc
    {
        Task<List<T>> GetSalles<T>();
        Task<List<T>> GetSallesByCinema<T>(int pIdCinema);
        Task<SalleDTO> GetSalleBySalleId(int salleId);
        Task DeleteSalle(int pId);
        Task DeleteSallesByCinemaId(int cinemaId);
        Task UpdateSalle(int pId, MajSalleDTO MajSalle);
        Task AddSalle(AjoutSalleDTO ajoutSalle);
 
    }
    public interface IFilmSvc
    {
        Task<List<T>> GetFilms<T>();
        Task<FilmsDTO> GetFilmByFilmId(int filmId);
        Task AddFilm(AjoutFilmsDTO ajoutFilm);
        Task UpdateFilm(int pId, FilmsDTO MajFilm);
        Task DeleteFilm(int pId);
    }
    public interface IProgrammationSvc
    {
        Task<List<T>> GetProgrammation<T>();
        Task AddProgrammation(AddProgrammationDTO programmation);
        Task<List<T>> GetProgrammationByFilm<T>(int pIdFilm);
        Task DeleteProgrammation(int pId);
    }
    public interface ITraductionSvc
    {
        Task<List<T>> GetLangues<T>();
        Task<List<T>> GetFilmTraduitByFilm<T>(int pIdFilm);
        Task AddTraduction(AddTraductionDTO trad);
        Task DeleteTraduction(int pId);

    }
    public interface ISeanceSvc
    {
        Task AddSeance(AddSeanceDTO pData);
        Task<List<T>> GetSeance<T>();
    }
    public interface IProjectionSvc
    {
        Task AddProjection(AddProjectionDTO pData);
        Task<List<T>> GetProjections<T>();
    }



}
