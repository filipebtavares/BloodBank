using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donor")]
    public class DonorController: ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetDonors()
        {

        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> GetDonorsById(int id)
        {

        }

        [HttpPost]
        public async Task<IActionResult> PostDonor()
        {

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDonor(int id)
        {

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonor(int id)
        {

        }
    }
}
