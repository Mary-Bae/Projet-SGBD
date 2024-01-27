﻿using Interfaces;
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
        public async Task<ActionResult> FindAllCinemas()
        {
            try
            {
                List<ChaineDTO> lst;
                lst = await _adminSvc.GetCinemaByChaine("sdsds");
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

                ICinemasSVC cinemasSvc = _adminSvc;
                lst = await cinemasSvc.GetCinemas<CinemasDTO>();

                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
