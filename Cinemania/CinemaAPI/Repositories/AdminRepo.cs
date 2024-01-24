﻿using Dapper;
using Interfaces;
using Models;
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

        public async Task<List<CinemasDTO>> GetCinema()
        {
            var lst = await _Connection.QueryAsync<CinemasDTO>("Select * from Cinemas");
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
