using AutoMapper;
using Domain.DTOs;
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
        private readonly IMapper _mapper;

        public TipoDevController(ITipoDevService tipoDevService, IMapper mapper)
        {
            _tipoDevService = tipoDevService;
            _mapper = mapper;
        }

        [HttpGet("TipoDev/Dev")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_mapper.Map<TipoDevDto>(_tipoDevService.GetAll()));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            
        }
    }
}
