using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

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
            IAdminSvc adminSvc = _adminSvc;

            var success = await adminSvc.AjouterChaineCinemaEtSalle(chaineCinemaEtSalle);

            if (success) return Ok();
            else return BadRequest("Erreur lors de l'ajout de la chaine de cinéma.");
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

        [HttpPost("Cinemas/AjouterCinema")]
        public async Task<IActionResult> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO)
        {
            ICinemasSvc cinemasSvc = _adminSvc;

            var success = await cinemasSvc.AjouterCinemaEtSalle(cinemaEtSalleDTO);

            if (success) return Ok();
            else return BadRequest("Erreur lors de l'ajout du cinéma et de la salle.");
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
                return BadRequest($"Erreur lors de la récupération des détails de la salle : {ex.Message}");
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
    }
}
