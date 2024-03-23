﻿using CustomErrors;
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
    public class AdminRepo : IAdminRepo, ISalleRepo, IFilmRepo
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
            if (pData.QtePlace <= 4 || pData.QteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.QtePlace % pData.QteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if(pData.NomChaine == "" || pData.NomChaine == null || pData.NomCinema == "" || pData.NomCinema == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);
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
                var parameters = new DynamicParameters();
                parameters.Add("@id", pId);

                await _Connection.ExecuteAsync("[Admin].[Chaine_Delete]", parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task UpdateChaine(int pId, MajChaineDTO pData)
        {
            if (pData.ch_nom == "" || pData.ch_nom == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);
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
        }
    
        async Task ICinemaRepo.UpdateCinema(int pId, MajCinemasDTO pData)
        {
            if (pData.ci_nom == "" || pData.ci_nom == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);
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
            if (pData.sa_qtePlace <= 4 || pData.sa_qteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.sa_numeroSalle <= 0)
                throw new CustomError(ErreurCodeEnum.NumeroInvalide);
            if (pData.sa_qtePlace % pData.sa_qteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);

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
            if (cinemaEtSalleDTO.QtePlace <= 4 || cinemaEtSalleDTO.QteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (cinemaEtSalleDTO.QtePlace % cinemaEtSalleDTO.QteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (cinemaEtSalleDTO.NomCinema == "" || cinemaEtSalleDTO.NomCinema == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);
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
            if (pData.sa_qtePlace <= 4 || pData.sa_qteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.sa_numeroSalle <= 0)
                throw new CustomError(ErreurCodeEnum.NumeroInvalide);
            if (pData.sa_qtePlace % pData.sa_qteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);

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
    }
}
