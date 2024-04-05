using CustomErrors;
using Dapper;
using Interfaces;
using Microsoft.Data.SqlClient;
using Models;
using System.Data;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repositories
{
    public class ClientRepo : IClientRepo, IClientFilmRepo, IClientCinemaRepo, IClientTraductionRepo, 
        IClientDatesRepo, IClientSalleRepo, IClientReservationRepo, IClientChaineRepo, IClientAbonnementRepo
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

        //Reservation
        public async Task<bool> AddReservation(ReservationDTO reservation)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ProjectionId", reservation.ProjectionId);
            parameters.Add("@NbrPersonnes", reservation.NbrPersonnes);
            parameters.Add("@ReservationDate", reservation.DateReservee);

            // Convertir la liste des sièges en une chaîne formatée
            string seatsFormatted = string.Join(",", reservation.Sieges.Select(s => $"{s.Row}{s.SeatNumber}"));
            parameters.Add("@Siege", seatsFormatted);

            // Exécution de la procédure stockée
            int affectedRows = await _Connection.ExecuteAsync("[Client].[Reservation_AddReservation]", parameters, commandType: CommandType.StoredProcedure);

            // Vérification si l'opération a affecté au moins une ligne
            return affectedRows > 0;
        }
        public async Task<List<SiegeDTO>> SiegesReservesByProjection(int projectionId, DateTime date)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ProjectionId", projectionId);
            parameters.Add("@Date", date);

            var seatsString = await _Connection.QueryAsync<string>("[Client].[Reservation_SelectSiegeByDate]", parameters, commandType: CommandType.StoredProcedure);

            var seats = new List<SiegeDTO>();

            // Traiter chaque élément de la liste retournée par la DB
            foreach (var seatChain in seatsString)
            {
                // Diviser chaque chaîne de siège (par exemple, "31,32" en "31" et "32")
                foreach (var seat in seatChain.Split(','))
                {
                    // Substring pour diviser le premier chiffre du 2e et remplir SiegeDTO
                    if (seat.Length >= 2 && int.TryParse(seat.Substring(0, 1), out int row) && int.TryParse(seat.Substring(1), out int seatNumber))
                    {
                        seats.Add(new SiegeDTO { Row = row, SeatNumber = seatNumber });
                    }
                }
            }

            return seats;
        }

        //Chaine
        public async Task<List<T>> GetChaine<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Chaine_SelectAll]");
            return lst.ToList();
        }
        //Abonnement
        public async Task<AbonnementInfosDTO> AddAbonnement(AbonnementDTO abonnement)
        {

            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ChaineId", abonnement.ChaineId);
                parameters.Add("@Uid", abonnement.Uid);
                parameters.Add("@DateAchat", abonnement.DateAchat);
                parameters.Add("@DateFinValidite", abonnement.DateFinValidite);

                return await _Connection.QueryFirstOrDefaultAsync<AbonnementInfosDTO>("[Client].[Abonnement_AddAbonnement]", parameters, commandType: CommandType.StoredProcedure);

            }
            catch (SqlException ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
    }
}
