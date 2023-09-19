using Domain.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace CrudDevs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class DevController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IDevService _devService;

        public DevController(IMediator mediator, IDevService devService)
        {
            _mediator = mediator;
            _devService = devService;
        }

        [HttpGet("DevTest/Dev")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_devService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("DevTest/Dev/{id}")]
        public IActionResult Get([FromServices] string id)
        {
            try
            {
                return Ok(_devService.GetById(new Guid(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }  
        }

        [HttpPost("DevTest/Dev")]
        public IActionResult Post([FromBody] AddDevRequest command)
        {
            try
            {
                return Ok(_mediator.Send(command));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("DevTest/Dev")]
        public IActionResult Put([FromBody] UpdateDevRequest command)
        {
            try
            {
                return Ok(_mediator.Send(command));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("DevTest/Dev")]
        public IActionResult Delete(DeleteDevRequest command)
        {
            try
            {
                return Ok(_mediator.Send(command));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}