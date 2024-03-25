using Models;

namespace Interfaces
{
    public interface IAdminSvc : ICinemasSvc, ISalleSvc, IFilmSvc, IProgrammationSvc
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
    }
    public interface IProgrammationSvc
    {
        Task AddProgrammation(ProgrammationDTO programmation);
        Task<List<T>> GetProgrammation<T>();
    }

}
