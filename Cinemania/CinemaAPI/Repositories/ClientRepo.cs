using Interfaces;
using System.Data;

namespace Repositories
{
    public class ClientRepo : IClientRepo
    {
        IDbConnection _Connection;
        public ClientRepo(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }
    }
}
