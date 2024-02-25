using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientSvc _clientSvc;
        public ClientController(IClientSvc pClientSvc)
        {
            _clientSvc = pClientSvc;
        }
    }
}
