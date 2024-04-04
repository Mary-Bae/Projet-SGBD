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

        [HttpPost("Reservation/AddReservation")]
        public async Task<IActionResult> Post(ReservationDTO reservation)
        {
            var success = await _clientSvc.AddReservation(reservation);
            if (success)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
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
    }
}
