using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/bloodBank")]
    public class BloodStockController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBloodById(int id)
        {

        }

        [HttpPost]
        public async Task<IActionResult> PostBlood()
        {

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBloodBank(int id)
        {

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedBloodOfBank(int id)
        {

        }
    }
}
