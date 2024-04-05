using CustomErrors;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CinemaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        IAdminSvc _adminSvc;
        public AdminController(IAdminSvc pAdminSvc)
        {
            _adminSvc = pAdminSvc;
        }

        // Chaines de cinema

        [HttpGet("Chaine")]
        public async Task<ActionResult> GetChaine()
        {
            try
            {
                List<ChaineDTO> lst;

                IAdminSvc adminSvc = _adminSvc;
                lst = await adminSvc.GetChaine<ChaineDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Chaine/AjouterChaine")]
        public async Task<IActionResult> AjouterChaineCinemaEtSalle(ChaineCinemaEtSalleDTO chaineCinemaEtSalle)
        {
            try
            {
                IAdminSvc adminSvc = _adminSvc;
                await adminSvc.AjouterChaineCinemaEtSalle(chaineCinemaEtSalle);
                return Ok();
            }
            catch (CustomError ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
        [HttpPut("Chaine/MajChaines/{id}")]
        public async Task<ActionResult> MajChaine(int id, MajChaineDTO data)
        {
            try
            {
                IAdminSvc adminSvc = _adminSvc;
                await adminSvc.UpdateChaine(id, data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Chaine/DelChaines/{id}")]
        public async Task<IActionResult> DeleteChaine(int id)
        {
            try
            {
                IAdminSvc adminSvc = _adminSvc;
                await adminSvc.DeleteChaine(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // Cinema

        [HttpGet("CinemasByChaine/{chaineId}")]
        public async Task<ActionResult> GetCinemasByChaine(int chaineId)
        {
            try
            {
                List<CinemasDTO> lst;
                ICinemasSvc cinemasSvc = _adminSvc;
                lst = await cinemasSvc.GetCinemasByChaine<CinemasDTO>(chaineId);
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

                ICinemasSvc cinemasSvc = _adminSvc;
                lst = await cinemasSvc.GetCinemas<CinemasDTO>();

                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Cinemas/MajCinemas/{id}")]
        public async Task<ActionResult> MajCinemas(int id, MajCinemasDTO data)
        {
            try
            {
                ICinemasSvc cinemasSvc = _adminSvc;
                await cinemasSvc.UpdateCinema(id, data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Cinemas/AjouterCinema")]
        public async Task<IActionResult> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO)
        {
            try
            {
                ICinemasSvc cinemasSvc = _adminSvc;
                await cinemasSvc.AjouterCinemaEtSalle(cinemaEtSalleDTO);
                return Ok();
            }
            catch (CustomError ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("Cinemas/DelCinemas/{cinemaId}")]
        public async Task<IActionResult> DeleteCinema(int cinemaId)
        {
            try
            {
                // Supprime d'abord toutes les salles associées au cinéma
                ISalleSvc SallesSvc = _adminSvc;
                await SallesSvc.DeleteSallesByCinemaId(cinemaId);

                // Ensuite, supprime le cinéma
                ICinemasSvc cinemasSvc = _adminSvc;
                await cinemasSvc.DeleteCinemas(cinemaId);

                return Ok("Cinéma et toutes les salles associées supprimés avec succès.");
            }
            catch (Exception ex)
            {
                return BadRequest("Erreur lors de la suppression : " + ex.Message);
            }

        }

        // Salles
        [HttpGet("Salles")]
        public async Task<ActionResult> GetSalles()
        {
            try
            {
                List<SalleDTO> lst;

                ISalleSvc salleSvc = _adminSvc;
                lst = await salleSvc.GetSalles<SalleDTO>();

                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Salles/AjoutSalle")]
        public async Task<IActionResult> AjouterSalle(AjoutSalleDTO ajoutSalleDTO)
        {
            
            try
            {
                ISalleSvc sallesSvc = _adminSvc;
                await sallesSvc.AddSalle(ajoutSalleDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Salles/MajSalle/{id}")]
        public async Task<ActionResult> MajSalle(int id, MajSalleDTO data)
        {
            try
            {
                ISalleSvc SallesSvc = _adminSvc;
                await SallesSvc.UpdateSalle(id, data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
      
        [HttpDelete("Salles/DelSalle/{id}")]
        public async Task<ActionResult> DelSalle(int id)
        {
            try
            {
                ISalleSvc sallesSvc = _adminSvc;
                await sallesSvc.DeleteSalle(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("SallesByCinema/{cinemaId}")]
        public async Task<ActionResult> GetSallesByCinema(int cinemaId)
        {
            try
            {
                List<SalleDTO> lst;
                ISalleSvc sallesSvc = _adminSvc;
                lst = await sallesSvc.GetSallesByCinema<SalleDTO>(cinemaId);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("SalleBySalleId/{salleId}")]
        public async Task<ActionResult<SalleDTO>> GetSalleBySalleId(int salleId)
        {
            try
            {
                ISalleSvc sallesSvc = _adminSvc;
                var salle = await sallesSvc.GetSalleBySalleId(salleId);

                if (salle != null)
                {
                    return Ok(salle); // Retourne directement l'objet SalleDTO
                }
                else
                {
                    return NotFound("Salle non trouvée."); // Aucune salle trouvée pour cet ID
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Films
        [HttpGet("Films")]
        public async Task<ActionResult> GetFilms()
        {
            try
            {
                List<FilmsDTO> lst;

                IFilmSvc filmSvc = _adminSvc;
                lst = await filmSvc.GetFilms<FilmsDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FilmByFilmId/{filmId}")]
        public async Task<ActionResult<FilmsDTO>> GetFilmByFilmId(int filmId)
        {
            try
            {
                IFilmSvc filmsSvc = _adminSvc;
                var film = await filmsSvc.GetFilmByFilmId(filmId);

                if (film != null)
                {
                    return Ok(film); // Retourne directement l'objet FilmDTO
                }
                else
                {
                    return NotFound("Film non trouvé.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Films/AjoutFilm")]
        public async Task<IActionResult> AjouterFilm(AjoutFilmsDTO ajoutFilmDTO)
        {

            try
            {
                IFilmSvc filmSvc = _adminSvc;
                await filmSvc.AddFilm(ajoutFilmDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Films/MajFilm/{id}")]
        public async Task<ActionResult> MajFilm(int id, FilmsDTO data)
        {
            try
            {
                IFilmSvc FilmsSvc = _adminSvc;
                await FilmsSvc.UpdateFilm(id, data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Films/DelFilm/{id}")]
        public async Task<ActionResult> DelFilm(int id)
        {
            try
            {
                IFilmSvc filmsSvc = _adminSvc;
                await filmsSvc.DeleteFilm(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Programmation
        [HttpPost("Programmation/AddProgrammation")]
        public async Task<IActionResult> AddProgrammation(AddProgrammationDTO programmationDTO)
        {
            try
            {
                IProgrammationSvc programmationSvc = _adminSvc;
                await programmationSvc.AddProgrammation(programmationDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Programmation")]
        public async Task<ActionResult> GetProgrammation()
        {
            try
            {
                List<ProgrammationAvecNomsDTO> lst;

                IProgrammationSvc programmationSvc = _adminSvc;
                lst = await programmationSvc.GetProgrammation<ProgrammationAvecNomsDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ProgrammationByFilm/{filmId}")]
        public async Task<ActionResult> GetProgrammationByFilm(int filmId)
        {
            try
            {
                List<ProgrammationAvecNomsDTO> lst;

                IProgrammationSvc programmationSvc = _adminSvc;
                lst = await programmationSvc.GetProgrammationByFilm<ProgrammationAvecNomsDTO>(filmId);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("Programmation/DelProgrammation/{id}")]
        public async Task<ActionResult> DelProgrammation(int id)
        {
            try
            {
                IProgrammationSvc programmationSvc = _adminSvc;
                await programmationSvc.DeleteProgrammation(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Traduction
        [HttpPost("Traduction/AddTraduction")]
        public async Task<IActionResult> AddTraduction(AddTraductionDTO traductionDTO)
        {
            try
            {
                ITraductionSvc traductionSvc = _adminSvc;
                await traductionSvc.AddTraduction(traductionDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Langues")]
        public async Task<ActionResult> GetLangues()
        {
            try
            {
                List<LangueDTO> lst;

                ITraductionSvc traductionSvc = _adminSvc;
                lst = await traductionSvc.GetLangues<LangueDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FilmTraduitByFilm/{filmId}")]
        public async Task<ActionResult> GetFilmTraduitByFilm(int filmId)
        {
            try
            {
                List<TraductionAvecNomsDTO> lst;
                ITraductionSvc traductionSvc = _adminSvc;
                lst = await traductionSvc.GetFilmTraduitByFilm<TraductionAvecNomsDTO>(filmId);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Traduction/DelTraduction/{id}")]
        public async Task<ActionResult> DelTraduction(int id)
        {
            try
            {
                ITraductionSvc traductionSvc = _adminSvc;
                await traductionSvc.DeleteTraduction(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Seance
        [HttpPost("Seance/AddSeance")]
        public async Task<IActionResult> AddSeance(AddSeanceDTO pData)
        {
            try
            {
                ISeanceSvc seanceSvc = _adminSvc;
                await seanceSvc.AddSeance(pData);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Seance")]
        public async Task<ActionResult> GetSeance()
        {
            try
            {
                List<SeanceDTO> lst;

                ISeanceSvc seanceSvc = _adminSvc;
                lst = await seanceSvc.GetSeance<SeanceDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Seance/DelSeance/{id}")]
        public async Task<ActionResult> DelSeance(int id)
        {
            try
            {
                ISeanceSvc seanceSvc = _adminSvc;
                await seanceSvc.DeleteSeance(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Projection
        [HttpPost("Projection/AddProjection")]
        public async Task<IActionResult> AddProjection(AddProjectionDTO pData)
        {
            try
            {
                IProjectionSvc projectionSvc = _adminSvc;
                await projectionSvc.AddProjection(pData);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Projection")]
        public async Task<ActionResult> GetProjections()
        {
            try
            {
                List<ProjectionDTO> lst;

                IProjectionSvc projectionSvc = _adminSvc;
                lst = await projectionSvc.GetProjections<ProjectionDTO>();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Projection/DelProjection/{id}")]
        public async Task<ActionResult> DelProjection(int id)
        {
            try
            {
                IProjectionSvc projectionSvc = _adminSvc;
                await projectionSvc.DeleteProjection(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
