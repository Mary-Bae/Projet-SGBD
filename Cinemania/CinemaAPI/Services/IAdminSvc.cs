namespace Interfaces
{
    public interface IAdminSvc
    {
        Task<List<string>> GetCinemaByChaine(string pChaineCinema);
    }
}
