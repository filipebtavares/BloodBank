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
        public async Task<IActionResult> GetAddressById(int id)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {

        }

    }
}
