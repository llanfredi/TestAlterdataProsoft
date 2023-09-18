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
            return Ok(_devService.GetAll());
        }

        [HttpGet("DevTest/Dev/{id}")]
        public IActionResult Get([FromServices] string id)
        {
            return Ok(_devService.GetById(new Guid(id)));
        }

        [HttpPost("DevTest/Dev")]
        public IActionResult Post([FromBody] AddDevRequest command)
        {
            return Ok(_mediator.Send(command));
        }

        [HttpPut("DevTest/Dev")]
        public IActionResult Put([FromBody] UpdateDevRequest command)
        {
            return Ok(_mediator.Send(command));
        }

        [HttpDelete("DevTest/Dev")]
        public IActionResult Delete(DeleteDevRequest command)
        {
            return Ok(_mediator.Send(command));
        }
    }
}