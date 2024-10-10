using Microsoft.AspNetCore.Mvc;
using BroadcastLibrary;

namespace BroadcastAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BroadcastController : ControllerBase
    {
        private readonly Broadcast _broadcast;

        public BroadcastController()
        {
            _broadcast = new Broadcast();
        }

        [HttpGet("getBroadcastMessage")]
        public IActionResult GetBroadcastMessage()
        {
            var message = _broadcast.BroadcastMessage();
            return Ok(message);
        }
    }
}
