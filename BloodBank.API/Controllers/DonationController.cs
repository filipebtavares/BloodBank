using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donation")]
    public class DonationController: ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetDonatios()
        {

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDonationsById(int id)
        {

        }

        [HttpPost]
        public async Task<IActionResult> PostDonation()
        {

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonatios(int id)
        {

        }
    }
}
