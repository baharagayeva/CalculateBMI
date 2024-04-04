using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyMassIndexController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetIndex(WaitIndex waitIndex)
        {
            var result =( waitIndex.Weight )/( waitIndex.Height * waitIndex.Height);
            return Ok(result);
        }

        public class WaitIndex
        {
            public double Weight { get; set; }

            public double Height { get; set; }
        }
    }
}
