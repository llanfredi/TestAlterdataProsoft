using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace CrudDevs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TipoDevController : ControllerBase
    {
        private readonly ITipoDevService _tipoDevService;

        public TipoDevController(ITipoDevService tipoDevService)
        {
            _tipoDevService = tipoDevService;
        }

        [HttpGet("TipoDev/Dev")]
        public IActionResult Get()
        {
            return Ok(_tipoDevService.GetAll());
        }
    }
}
