namespace Interfaces
{
    public interface IClientRepo : IClientFilmRepo
    {
    }
    public interface IClientFilmRepo
    {
        Task<List<T>> GetFilms<T>();
    }
}
