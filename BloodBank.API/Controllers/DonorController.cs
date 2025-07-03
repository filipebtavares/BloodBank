using BloodBank.Application.Commands.DeleteDonor;
using BloodBank.Application.Commands.InsertDonor;
using BloodBank.Application.Commands.UpdateDonor;
using BloodBank.Application.Queries.GetDonor;
using BloodBank.Application.Queries.GetDonorById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donor")]
    public class DonorController: ControllerBase
    {
        private readonly IMediator _mediator;

        public DonorController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetDonors(string search = "")
        {
            var query = await _mediator.Send(new GetDonorQuery());
            return Ok(query);
        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> GetDonorsById(int id)
        {
            var query = await _mediator.Send(new GetDonorsByIdQuery(id));

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> PostDonor(CreateDonorCommand command)
        {
            var query = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetDonorsById), new { id = query.Data }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDonor(int id, UpdateDonorCommand command)
        {
            var query = await _mediator.Send(command);

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonor(int id)
        {
            var query = await _mediator.Send(new DeleteDonorCommand(id));

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return NoContent();
        }
    }
}
