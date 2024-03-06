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

        [HttpPost("Chaine/AddChaines")]
        public async Task<ActionResult> PostChaine(AjoutChaineDTO data)
        {
            try
            {
                IAdminSvc adminSvc = _adminSvc;
                await adminSvc.AddChaine(data);
                return Ok();
            }
            catch (Exception ex)
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

        [HttpDelete("Cinemas/DelCinemas/{id}")]
        public async Task<ActionResult> DelCinemas(int id)
        {
            try
            {
                ICinemasSvc cinemasSvc = _adminSvc;
                await cinemasSvc.DeleteCinemas(id);
                return Ok();
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
        public async Task<ActionResult> AddSalle(AjoutSalleDTO data)
        {
            try
            {
                ISalleSvc salleSvc = _adminSvc;
                await salleSvc.AddSalle(data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AjouterCinemaEtSalle")]
        public async Task<IActionResult> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalleDTO)
        {
            ICinemasSvc cinemasSvc = _adminSvc;
            
            var success = await cinemasSvc.AjouterCinemaEtSalle(cinemaEtSalleDTO);

            if (success) return Ok();
            else return BadRequest("Erreur lors de l'ajout du cinéma et de la salle.");
        }
    }
}
