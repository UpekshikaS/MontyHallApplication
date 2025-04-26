using Microsoft.AspNetCore.Mvc;
using MontyHallApplication.Server.Services;

namespace MontyHallApplication.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MontyHallController : Controller
    {
        private readonly MontyHallSimulator _simulator;
        public MontyHallController()
        {
            _simulator = new MontyHallSimulator();
        }

        [HttpGet("simulate")]
        public IActionResult Simulate(int numberOfGames, bool switchChoice)
        {
            var (wins, losses) = _simulator.RunSimulations(numberOfGames, switchChoice);
            return Ok(new { wins, losses, numberOfGames });
        }
    }
}
