using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

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
    }
}
