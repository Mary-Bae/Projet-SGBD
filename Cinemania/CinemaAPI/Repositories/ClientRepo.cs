using Dapper;
using Interfaces;
using Models;
using System.Data;
using System.Data.Common;

namespace Repositories
{
    public class ClientRepo : IClientRepo, IClientFilmRepo, IClientCinemaRepo, IClientTraductionRepo, 
        IClientDatesRepo, IClientSalleRepo
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

        //Dates
        public async Task<DatesDTO?> GetDatesByProjection(int filmId, int cinemaId, int langueId, string horaire)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@FilmId", filmId, DbType.Int32);
            parameters.Add("@CinemaId", cinemaId, DbType.Int32);
            parameters.Add("@LangueId", langueId, DbType.Int32);
            parameters.Add("@Horaire", horaire, DbType.String);

            var result = await _Connection.QueryAsync<DatesDTO>("[Client].[Seance_GetDates]",parameters,commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        //Salle
        public async Task<SalleDTO> GetSalleByProjection(SalleByProjectionDTO pSalle, DateTime pDate)
        {
            var parameters = new DynamicParameters();
            
            parameters.Add("@CinemaId", pSalle.CinemaId);
            parameters.Add("@FilmId", pSalle.FilmId);
            parameters.Add("@LangueId", pSalle.LangueId);
            parameters.Add("@Horaire", pSalle.Horaire);
            parameters.Add("@DateSelected", pDate);

            var result = await _Connection.QueryAsync<SalleDTO>("[Client].[Salle_SalleByProjection]", parameters, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
