using CustomErrors;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System;

namespace CinemaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientSvc _clientSvc;
        public ClientController(IClientSvc pClientSvc)
        {
            _clientSvc = pClientSvc;
        }

        //Films
        [HttpGet("Films")]
        public async Task<ActionResult> GetFilms()
        {
            try
            {
                List<FilmsDTO> lst;

                IClientFilmSvc filmSvc = _clientSvc;
                lst = await filmSvc.GetFilms<FilmsDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FilmByCinema/{cinemaId}")]
        public async Task<ActionResult> GetFilmByCinema(int cinemaId)
        {
            try
            {
                List<FilmsDTO> lst;
                IClientFilmSvc filmsSvc = _clientSvc;
                lst = await filmsSvc.GetFilmByCinema<FilmsDTO>(cinemaId);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Cinema
        [HttpGet("Cinemas")]
        public async Task<ActionResult> GetCinemas()
        {
            try
            {
                List<CinemasDTO> lst;

                IClientCinemaSvc cinemasSvc = _clientSvc;
                lst = await cinemasSvc.GetCinemas<CinemasDTO>();

                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("CinemasByChaine/{chaineId}")]
        public async Task<ActionResult> GetCinemasByChaine(int chaineId)
        {
            try
            {
                List<CinemasDTO> lst;
                IClientCinemaSvc cinemasSvc = _clientSvc;
                lst = await cinemasSvc.GetCinemasByChaine<CinemasDTO>(chaineId);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Langue

        [HttpGet("LangueByFilmAndCinema/{cinemaId}/{filmId}")]
        public async Task<ActionResult> GetLanguesByFilmsAndCine(int cinemaId, int filmId)
        {
            try
            {
                List<LangueAndHoraireDTO> lst;
                IClientTraductionSvc traductionSvc = _clientSvc;
                lst = await traductionSvc.GetLanguesByFilmsAndCine<LangueAndHoraireDTO>(cinemaId, filmId);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Projection

        [HttpGet("GetDatesByProjection/{filmId}/{cinemaId}/{langueId}/{horaire}")]
        public async Task<IActionResult> GetDatesByProjection(int filmId, int cinemaId, int langueId, string horaire)
        {
            try
            {
                var dates = await _clientSvc.GetDatesByProjection(filmId, cinemaId, langueId, horaire);
                return Ok(dates);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("SalleByProjection")]
        public async Task<IActionResult> GetSalleByProjection(int CinemaId, int FilmId, int LangueId, string Horaire, string Date)
        {
            {
                try
                {
                    DateTime date = DateTime.Parse(Date);
                    var salleDetails = await _clientSvc.GetSalleByProjection(new SalleByProjectionDTO
                    {
                        CinemaId = CinemaId,
                        FilmId = FilmId,
                        LangueId = LangueId,
                        Horaire = Horaire,
                    }, date);

                    return Ok(salleDetails);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        //Reservation
        [HttpPost("Reservation/AddReservation")]
        public async Task<IActionResult> Post(ReservationDTO reservation)
        {
            bool success;
            string notificationMessage = null;

            // Vérifier si un UID d'abonnement est fourni
            if (!string.IsNullOrEmpty(reservation.UidAbonnement))
            {
                // Tenter une réservation avec abonnement
                success = await _clientSvc.AddReservationWithAbonnement(reservation);

                // Si la réservation est réussie, vérifier les places restantes pour l'abonnement
                if (success)
                {
                    notificationMessage = await NotifierPlacesRestantes(reservation.UidAbonnement);
                }
            }
            else
            {
                // Effectuer une réservation normale s'il n'y a pas d'UID d'abonnement
                success = await _clientSvc.AddReservation(reservation);
            }

            // Si la réservation a réussi, retourner un message de succès avec ou sans notification
            if (success)
            {
                if (!string.IsNullOrEmpty(notificationMessage))
                {
                    // Inclure le message de notification si disponible
                    return Ok(notificationMessage);
                }
                return Ok();
            }

            // Si la réservation a échoué, retourner un message d'échec
            return BadRequest("Échec de la réservation.");
        }
        private async Task<string> NotifierPlacesRestantes(string uidAbonnement)
        {
            int placesRestantes = await _clientSvc.GetPlacesRestantes(uidAbonnement);
            if (placesRestantes <= 2)
            {
                return "ATTENTION : Il ne reste que " + placesRestantes + " place(s) sur votre abonnement. N'hésitez pas à le renouveller";
            }
            return "";
        }

        [HttpGet("Reservation/SiegesReservesByProjection")]
        public async Task<IActionResult> SiegesReservesByProjection(int projectionId, DateTime date)
        {
            try
            {
                var reservedSeats = await _clientSvc.SiegesReservesByProjection(projectionId, date);
                return Ok(reservedSeats);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Chaine
        [HttpGet("Chaine")]
        public async Task<ActionResult> GetChaine()
        {
            try
            {
                List<ChaineDTO> lst;

                IClientChaineSvc clientSvc = _clientSvc;
                lst = await clientSvc.GetChaine<ChaineDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Abonnement
        [HttpPost("Abonnement/AddAbonnement")]
        public async Task<IActionResult> AddAbonnement(ChaineIdDTO chaineIdDto)
        {
            try
            {
                IClientAbonnementSvc clientSvc = _clientSvc;
                var abonnementInfo = await _clientSvc.AddAbonnement(chaineIdDto.ch_id);

                if (abonnementInfo != null)
                    return Ok(abonnementInfo);
                else
                {
                    return BadRequest("Impossible de créer l'abonnement.");
                }
            }
            catch (CustomError ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
