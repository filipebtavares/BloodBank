using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/address")]
    public class AddressController: ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAddress()
        {

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressByCep(string cep)
        {

        }

        [HttpPost]
        public async Task<IActionResult> PostAddress()
        {

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(int id)
        {

        }

    }
}
