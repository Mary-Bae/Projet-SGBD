using Dapper;
using Interfaces;
using System.Data;

namespace Repositories
{
    public class ClientRepo : IClientRepo, IClientFilmRepo
    {
        IDbConnection _Connection;
        public ClientRepo(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }

        public async Task<List<T>> GetFilms<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Films_SelectAll]");
            return lst.ToList();
        }
    }
}
