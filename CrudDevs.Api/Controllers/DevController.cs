using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        public IActionResult Get([FromServices] IMediator _mediator, string id)
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

        [HttpDelete("DevTest/Dev/{id}")]
        public IActionResult Delete(DeleteDevRequest command)
        {
            return Ok(_mediator.Send(command));
        }
    }
}