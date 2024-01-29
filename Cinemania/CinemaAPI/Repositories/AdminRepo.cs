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

        async Task ICinemaRepo.Delete(int pId)
        {
            Dictionary<string, object> dbParams = new Dictionary<string, object>();
            dbParams.Add("@id", pId);

            await _Connection.ExecuteAsync("[admin].[Cinemas_Delete]", dbParams);
        }
        async Task ICinemaRepo.Update(MajCinemasDTO pData)
        {
            Dictionary<string, object> dbParams = new Dictionary<string, object>();

            dbParams.Add("@id", pData.CINE_ID); 
            dbParams.Add("@Nom", pData.CINE_Nom);
            dbParams.Add("@NbrSalles", pData.CINE_NbrSalles);

            await _Connection.ExecuteAsync("[admin].[Cinemas_Update]", dbParams);
        }


        //Task<List<CinemasDTO>> IReservationRepo.GetCinema3()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
