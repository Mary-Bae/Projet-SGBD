﻿using Interfaces;
using Models;
using CustomErrors;
using System.Linq.Expressions;

namespace Services
{
    public class AdminSvc : IAdminSvc, ICinemasSvc, ISalleSvc, IFilmSvc, IProgrammationSvc
    {
        IAdminRepo _adminRepo;
        public AdminSvc(IAdminRepo pAdminRepo)
        {
            _adminRepo = pAdminRepo;
        }

        // chaine de cinema
        async Task<List<T>> IAdminSvc.GetChaine<T>()
        {
            IAdminRepo adminRepo = _adminRepo;
            var lst = await adminRepo.GetChaine<T>();
            return lst.ToList<T>();
        }

        public async Task<bool> AjouterChaineCinemaEtSalle(ChaineCinemaEtSalleDTO pData)
        {
            if (pData.QtePlace <= 4 || pData.QteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.QtePlace % pData.QteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.NomChaine == "" || pData.NomChaine == null || pData.NomCinema == "" || pData.NomCinema == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);

            return await _adminRepo.AjouterChaineCinemaEtSalle(pData);
        }
        async Task IAdminSvc.DeleteChaine(int pId)
        {
            IAdminRepo adminRepo = _adminRepo;
            await adminRepo.DeleteChaine(pId);
        }

        public Task UpdateChaine(int pId, MajChaineDTO pData)
        {
            if (pData.ch_nom == "" || pData.ch_nom == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);
            return _adminRepo.UpdateChaine(pId, pData);
        }

        // Cinema
        public async Task<List<T>> GetCinemasByChaine<T>(int pId)
        {
            return await _adminRepo.GetCinemasByChaine<T>(pId);
        }

        async Task<List<T>> ICinemasSvc.GetCinemas<T>()
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            var lst = await cinemasRepo.GetCinemas<T>();
            return lst.ToList<T>();
        }
        async Task ICinemasSvc.DeleteCinemas(int pId)
        {
            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.DeleteCinemas(pId);
        }
        async Task ICinemasSvc.UpdateCinema(int pId, MajCinemasDTO pData)
        {
            if (pData.ci_nom == "" || pData.ci_nom == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);

            ICinemaRepo cinemasRepo = _adminRepo;
            await cinemasRepo.UpdateCinema(pId, pData);
        }

        // Salles de cinema

        public async Task<List<T>> GetSallesByCinema<T>(int pId)
        {
            return await _adminRepo.GetSallesByCinema<T>(pId);
        }
        public async Task<SalleDTO> GetSalleBySalleId(int salleId)
        {
            ISalleRepo salleRepo = _adminRepo;
            var salle = await salleRepo.GetSalleBySalleId(salleId);

            if (salle != null)
            {
                return new SalleDTO
                {
                    sa_id = salle.sa_id,
                    sa_numeroSalle = salle.sa_numeroSalle,
                    sa_qteRangees = salle.sa_qteRangees,
                    sa_qtePlace = salle.sa_qtePlace,
                    sa_qtePlace_Rangee= salle.sa_qtePlace_Rangee,
                    sa_ci_id= salle.sa_ci_id
                };
            }

            return null;
        }
        async Task<List<T>> ISalleSvc.GetSalles<T>()
        {
            ISalleRepo salleRepo = _adminRepo;
            var lst = await salleRepo.GetSalles<T>();
            return lst.ToList<T>();
        }
        async Task ISalleSvc.AddSalle(AjoutSalleDTO pData)
        {
            if (pData.sa_qtePlace <= 4 || pData.sa_qteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.sa_numeroSalle <= 0)
                throw new CustomError(ErreurCodeEnum.NumeroInvalide);
            if (pData.sa_qtePlace % pData.sa_qteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);

                ISalleRepo salleRepo = _adminRepo;
                await salleRepo.AddSalle(pData);
        }

        public async Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO)
        {
            if (cinemaEtSalleDTO.QtePlace <= 4 || cinemaEtSalleDTO.QteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (cinemaEtSalleDTO.QtePlace % cinemaEtSalleDTO.QteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (cinemaEtSalleDTO.NomCinema == "" || cinemaEtSalleDTO.NomCinema == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);

            return await _adminRepo.AjouterCinemaEtSalle(cinemaEtSalleDTO);
        }
        async Task ISalleSvc.DeleteSalle(int pId)
        {
            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.DeleteSalle(pId);
        }
        public async Task DeleteSallesByCinemaId(int cinemaId)
        {
            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.DeleteSallesByCinemaId(cinemaId);
        }

        async Task ISalleSvc.UpdateSalle(int pId, MajSalleDTO pData)
        {
            if (pData.sa_qtePlace <= 4 || pData.sa_qteRangees <= 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);
            if (pData.sa_numeroSalle <= 0)
                throw new CustomError(ErreurCodeEnum.NumeroInvalide);
            if (pData.sa_qtePlace % pData.sa_qteRangees != 0)
                throw new CustomError(ErreurCodeEnum.QuantiteMinimaleDePlaces);

            ISalleRepo salleRepo = _adminRepo;
            await salleRepo.UpdateSalle(pId, pData);
        }

        // Films

        async Task<List<T>> IFilmSvc.GetFilms<T>()
        {
            IFilmRepo filmRepo = _adminRepo;
            var lst = await filmRepo.GetFilms<T>();
            return lst.ToList<T>();
        }
        async Task IFilmSvc.AddFilm(AjoutFilmsDTO pData)
        {
            if (pData.fi_nom == "" || pData.fi_nom == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);

            IFilmRepo filmRepo = _adminRepo;
            await filmRepo.AddFilm(pData);
        }
        async Task IFilmSvc.UpdateFilm(int pId, FilmsDTO pData)
        {
            if (pData.fi_nom == "" || pData.fi_nom == null)
                throw new CustomError(ErreurCodeEnum.ChampVide);

            IFilmRepo filmRepo = _adminRepo;
            await filmRepo.UpdateFilm(pId, pData);
        }
        public async Task<FilmsDTO> GetFilmByFilmId(int filmId)
        {
            IFilmRepo filmRepo = _adminRepo;
            var film = await filmRepo.GetFilmByFilmId(filmId);

            if (film != null)
            {
                return new FilmsDTO
                {
                    fi_id = film.fi_id,
                    fi_nom = film.fi_nom,
                    fi_description = film.fi_description,
                    fi_genre = film.fi_genre,
                };
            }
            return null;
        }
        async Task IFilmSvc.DeleteFilm(int pId)
        {
            IFilmRepo filmRepo = _adminRepo;
            await filmRepo.DeleteFilm(pId);
        }

        // Programmation

        async Task IProgrammationSvc.AddProgrammation(ProgrammationDTO pData)
        {
            IProgrammationRepo programmationRepo = _adminRepo;
            await programmationRepo.AddProgrammation(pData);
        }
        async Task<List<T>> IProgrammationSvc.GetProgrammation<T>()
        {
            IProgrammationRepo programmationRepo = _adminRepo;
            var lst = await programmationRepo.GetProgrammation<T>();
            return lst.ToList<T>();
        }
        async Task IProgrammationSvc.DeleteProgrammation(int pId)
        {
            IProgrammationRepo programmationRepo = _adminRepo;
            await programmationRepo.DeleteProgrammation(pId);
        }
    }
}
