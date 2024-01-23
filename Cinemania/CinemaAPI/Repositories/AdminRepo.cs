using Dapper;
using Interfaces;
using System.Data;

namespace Repositories
{
    public class AdminRepo : IAdminRepo
    {
        IDbConnection _Connection;
        public AdminRepo(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }

        public async Task<dynamic> GetCinema()
        {
            var lst = await _Connection.ExecuteReaderAsync("");
            return lst;
        }
    }
}
