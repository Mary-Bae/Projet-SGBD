using Dapper;
using Interfaces;
using Models;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Repositories
{
    public class AdminRepo : IAdminRepo
    {
        IDbConnection _Connection;
        public AdminRepo(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }
        public async Task<List<ChaineDTO>> GetChaine()
        {
            var lst = await _Connection.QueryAsync<ChaineDTO>("Select * from Chaine");
            return lst.ToList();
        }
        public async Task<List<T>> GetCinemas<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[admin].[Cinemas_SelectAll]");
            return lst.ToList();
        }

        //Task<List<CinemasDTO>> ICinemaRepo.GetCinema2()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<List<CinemasDTO>> IReservationRepo.GetCinema3()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
