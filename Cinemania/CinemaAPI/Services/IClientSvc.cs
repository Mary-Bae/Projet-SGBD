namespace Interfaces
{
    public interface IClientSvc : IClientFilmSvc
    {
    }
    public interface IClientFilmSvc
    {
        Task<List<T>> GetFilms<T>();
    }
}
