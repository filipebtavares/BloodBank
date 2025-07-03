using BloodBank.Application.Commands.DeleteBloodStock;
using BloodBank.Application.Commands.InsertBloodStock;
using BloodBank.Application.Commands.UpdateBloodStock;
using BloodBank.Application.Queries.GetBloodStockById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/bloodStock")]
    public class BloodStockController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BloodStockController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBloodById(int id)
        {
            var query = await _mediator.Send(new GetBloodStockByIQuery(id));

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> PostBlood(CreateBloodStockCommand command)
        {
            var query = await _mediator.Send(command);

            return Created($"/api/bloodStock/{query.Data}", query);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBloodStock(int id, UpdateBloodStockCommand command)
        {
            var query = await _mediator.Send(command);
            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedBloodStock(int id)
        {
            var query = await _mediator.Send(new DeleteBloodStockCommand(id));
            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);
        }
    }
}
