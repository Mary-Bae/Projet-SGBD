namespace Interfaces
{
    public interface IClientSvc
    {
        Task<List<T>> GetCinemas<T>();
    }
}
