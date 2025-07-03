using BloodBank.Application.Commands.InsertAddress;
using BloodBank.Application.Commands.UpdateAddress;
using BloodBank.Application.Queries.GetAddress;
using BloodBank.Application.Queries.GetAddressByCep;
using BloodBank.Application.Queries.GetAddressById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/address")]
    public class AddressController: ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAddress()
        {
            var query = await _mediator.Send(new GetAddressQuery());

            return Ok(query);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var query = await _mediator.Send(new GetAddressByIdQuery(id));

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);

        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetAddressByCep(string cep)
        {
            var query = await _mediator.Send(new GetAddressByCepQuery(cep));

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> PostAddress(CreateAddressCommand command)
        {
            var query = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetAddressById), new { id = query.Data }, query);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(int id, UpdateAddressCommand command)
        {
            var query = await _mediator.Send(command);

            if (!query.IsSucess)
            {
                return BadRequest(query.Message);
            }

            return Ok(query);
        }

    }
}
