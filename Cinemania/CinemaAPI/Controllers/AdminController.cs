using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CinemaAPI.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost("AddChaines")]
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

        [HttpPut("MajChaines/{id}")]
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

        [HttpDelete("DeleteChaines/{id}")]
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

        [HttpDelete("DeleteCinemas/{id}")]
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
        
        [HttpPut("MajCinemas/{id}")]
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
        [HttpPost("AjoutCinemas")]
        public async Task<ActionResult> AddCinemas(AjoutCinemasDTO data)
        {
            try
            {
                ICinemasSvc cinemasSvc = _adminSvc;
                await cinemasSvc.AddCinema(data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Salles de cinema

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
    }
}
