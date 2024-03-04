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
        public async Task<List<T>> GetChaine<T>()
        {
            var lst = await _Connection.QueryAsync<T>("[Client].[Chaine_SelectAll]");
            return lst.ToList();
        }

        public async Task AddChaine(AjoutChaineDTO pData)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Nom", pData.ch_nom);

            await _Connection.ExecuteAsync("[Admin].[Chaine_AddChaine]", parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task DeleteChaine(int pId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", pId);

            await _Connection.ExecuteAsync("[Admin].[Chaine_Delete]", parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task UpdateChaine(int pId, MajChaineDTO pData)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", pId);
            parameters.Add("@NouveauNom", pData.ch_nom);

            await _Connection.ExecuteAsync("[Admin].[Chaine_Update]", parameters, commandType: CommandType.StoredProcedure);
        }

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
            var parameters = new DynamicParameters();
            parameters.Add("@id", pId);

            await _Connection.ExecuteAsync("[Admin].[Cinema_Delete]", parameters, commandType: CommandType.StoredProcedure);
        }
    
        async Task ICinemaRepo.UpdateCinema(int pId, MajCinemasDTO pData)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", pId);
            parameters.Add("@Nom", pData.ci_nom);
            parameters.Add("@Adresse", pData.ci_adresse);
            parameters.Add("@CineChaine", pData.ci_ch_id);

            await _Connection.ExecuteAsync("[Admin].[Cinema_Update]", parameters, commandType: CommandType.StoredProcedure);
        }
        async Task ICinemaRepo.AddCinema(AjoutCinemasDTO pData)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Nom", pData.ci_nom);
            parameters.Add("@Adresse", pData.ci_adresse);
            parameters.Add("@CineChaine", pData.ci_ch_id);

            await _Connection.ExecuteAsync("[Admin].[Cinema_AddCinema]", parameters, commandType: CommandType.StoredProcedure);
        }




        //Task<List<CinemasDTO>> IReservationRepo.GetCinema3()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
