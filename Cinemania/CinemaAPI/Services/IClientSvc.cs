namespace Interfaces
{
    public interface IClientSvc : IClientFilmSvc, IClientCinemaSvc
    {
    }
    public interface IClientFilmSvc
    {
        Task<List<T>> GetFilms<T>();
    }
    public interface IClientCinemaSvc
    {
        Task<List<T>> GetCinemas<T>();
    }
}
