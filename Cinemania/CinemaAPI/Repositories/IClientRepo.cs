namespace Interfaces
{
    public interface IClientRepo : IClientFilmRepo, IClientCinemaRepo
    {
    }
    public interface IClientFilmRepo
    {
        Task<List<T>> GetFilms<T>();
    }
    public interface IClientCinemaRepo
    {
        Task<List<T>> GetCinemas<T>();
    }
}
