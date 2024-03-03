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
        public async Task<ActionResult> MajChaine(int id, AjoutChaineDTO data)
        {
            try
            {
                IAdminSvc adminSvc = _adminSvc;
                ChaineDTO chaineToUpdate = new ChaineDTO { ch_id = id, ch_nom = data.ch_nom };
                await adminSvc.UpdateChaine(chaineToUpdate);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Chaines/{id}")]
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

        [HttpDelete("Cinemas/{id}")]
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
        
        [HttpPost("Cinemas")]
        public async Task<ActionResult> PostCinemas(MajCinemasDTO data)
        {
            try
            {
                ICinemasSvc cinemasSvc = _adminSvc;
                await cinemasSvc.Update(data);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
