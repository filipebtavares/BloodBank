using BloodBank.Application.Commands.DeleteDonation;
using BloodBank.Application.Commands.InsertDonation;
using BloodBank.Application.Queries.GetDonations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donation")]
    public class DonationController: ControllerBase
    {
        private readonly IMediator _mediator;

        public DonationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetDonatios()
        {
            var query = await _mediator.Send(new GetDonationsQuery());

            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> PostDonation(CreateDonationCommand command)
        {
            var query = await _mediator.Send(command);

            return Created($"api/donation/{query.Data}", query);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonatios(int id)
        {
            var query = await _mediator.Send(new DeleteDonationCommand(id));

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return NoContent();
        }
    }
}
