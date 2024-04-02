using Dapper;
using Interfaces;
using Models;
using System.Data;

namespace Repositories
{
    public class ClientRepo : IClientRepo, IClientFilmRepo, IClientCinemaRepo, IClientTraductionRepo
    {
        IDbConnection _Connection;
        public ClientRepo(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }

        //Films
        public async Task<List<T>> GetFilms<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Films_SelectAll]");
            return lst.ToList();
        }
        public async Task<List<T>> GetFilmByCinema<T>(int pId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CinemaId", pId);
            var lst = await _Connection.QueryAsync<T>("[Client].[Films_SelectByCinema]", parameters, commandType: CommandType.StoredProcedure);
            return lst.ToList();
        }

        //Cinemas
        public async Task<List<T>> GetCinemas<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Cinema_SelectAll]");
            return lst.ToList();
        }

        //Traduction

        public async Task<List<T>> GetLanguesByFilmsAndCine<T>(int pCinema, int pFilm)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CinemaId", pCinema);
            parameters.Add("@FilmId", pFilm);
            var lst = await _Connection.QueryAsync<T>("[Client].[Langue_SelectByCinemaAndFilms]", parameters, commandType: CommandType.StoredProcedure);
            return lst.ToList();
        }
    }
}
