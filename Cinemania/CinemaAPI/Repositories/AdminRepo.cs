using CustomErrors;
using Dapper;
using Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Data;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories
{
    public class AdminRepo : IAdminRepo, ISalleRepo, IFilmRepo, IProgrammationRepo,
        ITraductionRepo, ISeanceRepo, IProjectionRepo
    {
        IDbConnection _Connection;
        public AdminRepo(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }

        // Chaines de cinema
        public async Task<List<T>> GetChaine<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Chaine_SelectAll]");
            return lst.ToList();
        }
        public async Task<bool> AjouterChaineCinemaEtSalle(ChaineCinemaEtSalleDTO pData)
        {
            try
            {
                // Logique pour appeler la procédure stockée avec les paramètres du DTO
                var parameters = new DynamicParameters(new
                {
                    NomChaine = pData.NomChaine,
                    NomCinema = pData.NomCinema,
                    AdresseCinema = pData.AdresseCinema,
                    NumeroSalle = pData.NumeroSalle,
                    QteRangees = pData.QteRangees,
                    QtePlace = pData.QtePlace,
                    QtePlacesRangee = pData.QtePlacesRangee
                });

                await _Connection.ExecuteAsync("[Admin].[AjouterChaineCinemaEtSalle]", parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch(SqlException ex)
            {
                if(ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_CHAINE_NOM, ex);
                if(ex.Number == 0x00000a43)
                    throw new CustomError(ErreurCodeEnum.UK_CINEMA_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch(Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }       
        }
        public async Task DeleteChaine(int pId)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[Chaine_Delete]", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task UpdateChaine(int pId, MajChaineDTO pData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);
                parameters.Add("@NouveauNom", pData.ch_nom);

                await _Connection.ExecuteAsync("[Admin].[Chaine_Update]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_CHAINE_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }

        // Cinemas
        public async Task<List<T>> GetCinemasByChaine<T>(int pId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ch_id", pId);
            var lst = await _Connection.QueryAsync<T>("[Admin].[Cinema_SelectByChain]", parameters, commandType: CommandType.StoredProcedure);
            return lst.ToList();
        }
        public async Task<List<T>> GetCinemas<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Cinema_SelectAll]");
            return lst.ToList();
        }
        async Task ICinemaRepo.DeleteCinemas(int pId)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[Cinema_Delete]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch(SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_CHAINE_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        async Task ICinemaRepo.UpdateCinema(int pId, MajCinemasDTO pData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);
                parameters.Add("@Nom", pData.ci_nom);
                parameters.Add("@Adresse", pData.ci_adresse);
                parameters.Add("@CineChaine", pData.ci_ch_id);

                await _Connection.ExecuteAsync("[Admin].[Cinema_Update]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000223)
                    throw new CustomError(ErreurCodeEnum.FK_SALLE_CINEMA, ex);
                if (ex.Number == 0x00000a43)
                    throw new CustomError(ErreurCodeEnum.UK_CINEMA_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }

        }

        // Salles de cinema
        public async Task<List<T>> GetSallesByCinema<T>(int pId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ci_id", pId);
            var lst = await _Connection.QueryAsync<T>("[Client].[Salle_SelectByCinema]", parameters, commandType: CommandType.StoredProcedure);
            return lst.ToList();
        }
        public async Task<List<T>> GetSalles<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Salle_SelectAll]");
            return lst.ToList();
        }
        async Task ISalleRepo.AddSalle(AjoutSalleDTO pData)
        {

            try {    
            var parameters = new DynamicParameters();
            parameters.Add("@NumeroSalle", pData.sa_numeroSalle);
            parameters.Add("@QtePlace", pData.sa_qtePlace);
            parameters.Add("@QteRangees", pData.sa_qteRangees);
            parameters.Add("@QtePlaces_Rangee", pData.sa_qtePlace_Rangee);
            parameters.Add("@CinemaId", pData.sa_ci_id);

            await _Connection.ExecuteAsync("[Admin].[Salle_AddSalle]", parameters, commandType: CommandType.StoredProcedure);

            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_SALLE_NUMBER, ex);
                if (ex.Number == 0x00000223)
                    throw new CustomError(ErreurCodeEnum.FK_SALLE_CINEMA, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        public async Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO)
        {   
            try {
                var parameters = new DynamicParameters(new
                {
                    NomCinema = cinemaEtSalleDTO.NomCinema,
                    AdresseCinema = cinemaEtSalleDTO.AdresseCinema,
                    CineChaineId = cinemaEtSalleDTO.CineChaineId,
                    NumeroSalle = cinemaEtSalleDTO.NumeroSalle,
                    QteRangees = cinemaEtSalleDTO.QteRangees,
                    QtePlace = cinemaEtSalleDTO.QtePlace,
                    QtePlacesRangee = cinemaEtSalleDTO.QtePlacesRangee
            });
                await _Connection.ExecuteAsync("[Admin].[AjouterCinemaEtSalle]", parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a43)
                    throw new CustomError(ErreurCodeEnum.UK_CINEMA_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        async Task ISalleRepo.DeleteSalle(int pId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", pId);

            await _Connection.ExecuteAsync("[Admin].[Salle_Delete]", parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task DeleteSallesByCinemaId(int cinemaId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CinemaId", cinemaId);
            await _Connection.ExecuteAsync("[Admin].[Salle_DeleteSallesByCinemaId]", parameters, commandType: CommandType.StoredProcedure);
        }
        async Task ISalleRepo.UpdateSalle(int pId, MajSalleDTO pData)
        {
            try
          {
            var parameters = new DynamicParameters();
            parameters.Add("@id", pId);
            parameters.Add("@NumeroSalle", pData.sa_numeroSalle);
            parameters.Add("@QtePlace", pData.sa_qtePlace);
            parameters.Add("@QteRangees", pData.sa_qteRangees);
            parameters.Add("@QtePlaces_Rangee", pData.sa_qtePlace_Rangee);
            parameters.Add("@CinemaId", pData.sa_ci_id);

            await _Connection.ExecuteAsync("[Admin].[Salle_Update]", parameters, commandType: CommandType.StoredProcedure);
          }
          catch (SqlException ex)
          {
              if (ex.Number == 0x00000a29)
              {
                  throw new CustomError(ErreurCodeEnum.UK_SALLE_NUMBER, ex);
              }
              throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
          }
          catch (Exception ex)
          {
              throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
          }
      }
        public async Task<SalleDTO> GetSalleBySalleId(int salleId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", salleId);

            var salle = await _Connection.QueryFirstOrDefaultAsync<SalleDTO>("[Admin].[Salle_SelectBySalle]", parameters, commandType: CommandType.StoredProcedure);

            return salle;
        }

        // Films
        public async Task<List<T>> GetFilms<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Films_SelectAll]");
            return lst.ToList();
        }
        public async Task<FilmsDTO> GetFilmByFilmId(int filmId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", filmId);

            var film = await _Connection.QueryFirstOrDefaultAsync<FilmsDTO>("[Admin].[Film_SelectByFilm]", parameters, commandType: CommandType.StoredProcedure);

            return film;
        }
        async Task IFilmRepo.AddFilm(AjoutFilmsDTO pData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FilmNom", pData.fi_nom);
                parameters.Add("@Genre", pData.fi_genre);
                parameters.Add("@Description", pData.fi_description);

                await _Connection.ExecuteAsync("[Admin].[Films_AddFilms]", parameters, commandType: CommandType.StoredProcedure);

            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_FILM_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        async Task IFilmRepo.UpdateFilm(int pId, FilmsDTO pData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);
                parameters.Add("@NomFilm", pData.fi_nom);
                parameters.Add("@Description", pData.fi_description);
                parameters.Add("@Genre", pData.fi_genre);

                await _Connection.ExecuteAsync("[Admin].[Film_Update]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_FILM_NOM, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        async Task IFilmRepo.DeleteFilm(int pId)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[Film_Delete]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch(SqlException ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }

        }

        // Programmation
        public async Task AddProgrammation(AddProgrammationDTO programmation)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FilmTraduitId", programmation.FilmTraduitId);
                parameters.Add("@DateProgrammation", programmation.DateProgrammation);

                await _Connection.ExecuteAsync("[Admin].[AjouterProgrammation]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a43)
                    throw new CustomError(ErreurCodeEnum.UK_PROGRAMMATION, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        public async Task<List<T>> GetProgrammation<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Admin].[Programmation_SelectAll]");
            return lst.ToList();
        }
        public async Task<List<T>> GetProgrammationByFilm<T>(int pFilmId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@FilmId", pFilmId);
            var lst = await _Connection.QueryAsync<T>("[Admin].[ProgrammationAvecNoms]", parameters, commandType: CommandType.StoredProcedure);
            return lst.ToList();
        }
        public async Task<T> GetProgrammationById<T>(int pId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ProgrammationId", pId);
            return await _Connection.QuerySingleOrDefaultAsync<T>("[Admin].[Programmation_SelectProgrammationById]", parameters, commandType: CommandType.StoredProcedure);
            
        }
        async Task IProgrammationRepo.DeleteProgrammation(int pId)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[Programmation_Delete]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000223)
                    throw new CustomError(ErreurCodeEnum.FK_SEANCE_PROGRAMMATION, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }

        }

        // Traduction
        public async Task AddTraduction(AddTraductionDTO trad)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FilmId", trad.FilmId);
                parameters.Add("@LangueId", trad.LangueId);

                await _Connection.ExecuteAsync("[Admin].[FilmTraduit_AddFilmTraduit]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_TRADUCTION, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        public async Task<List<T>>GetLangues<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Admin].[Langue_SelectAll]");
            return lst.ToList();
        }
        public async Task<List<T>> GetFilmTraduitByFilm<T>(int pIdFilm)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@FilmId", pIdFilm);
            var lst = await _Connection.QueryAsync<T>("[Admin].[FilmTraduitAvecNoms]", parameters, commandType: CommandType.StoredProcedure);
            return lst.ToList();
        }
        async Task ITraductionRepo.DeleteTraduction(int pId)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[FilmTraduit_Delete]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000223)
                    throw new CustomError(ErreurCodeEnum.FK_PROGRAMMATION_FILMTRADUIT, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }

        // Seance
        public async Task AddSeance(AddSeanceDTO pData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Horaire", pData.se_horaire);
                parameters.Add("@DateFin", pData.se_dateFin);
                parameters.Add("@ProgrammationId", pData.se_pr_id);

                await _Connection.ExecuteAsync("[Admin].[Seance_AddSeance]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_SEANCE, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        public async Task<List<T>> GetSeance<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Admin].[Seance_SelectAll]");
            return lst.ToList();
        }
        async Task ISeanceRepo.DeleteSeance(int pId)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[Seance_Delete]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000223)
                    throw new CustomError(ErreurCodeEnum.FK_PROJECTION_SEANCE, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }

        // Projection
        public async Task AddProjection(AddProjectionDTO pData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SeanceId", pData.SeanceId);
                parameters.Add("@SalleId", pData.SalleId);

                await _Connection.ExecuteAsync("[Admin].[Projection_AddProjection]", parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0x00000a29)
                    throw new CustomError(ErreurCodeEnum.UK_PROJECTION, ex);
                if (ex.Number == 0x0000c350)
                    throw new CustomError(ErreurCodeEnum.ConflitProjection, ex);
                throw new CustomError(ErreurCodeEnum.ErreurSQL, ex);
            }
            catch (Exception ex)
            {
                throw new CustomError(ErreurCodeEnum.ErreurGenerale, ex);
            }
        }
        public async Task<List<T>> GetProjections<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Admin].[Projection_SelectAll]");
            return lst.ToList();
        }
    }
}