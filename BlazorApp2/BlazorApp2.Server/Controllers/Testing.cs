using Microsoft.AspNetCore.Mvc;

namespace InternshipBlazorApp.Server.Controllers
{
    [ApiController]
    [Route("test")]
    public class Testing : ControllerBase
    {
        private readonly ILogger<Testing> _logger;

        public Testing(ILogger<Testing> logger)
        {
            _logger = logger;
        }

        [HttpGet("testing")]
        public IActionResult GetTesting()
        {
            return Ok("This is a test!");
        }
    }
}
