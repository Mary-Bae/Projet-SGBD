namespace Interfaces
{
    public interface IClientRepo
    {
        Task<List<T>> GetCinemas<T>();
    }
}
