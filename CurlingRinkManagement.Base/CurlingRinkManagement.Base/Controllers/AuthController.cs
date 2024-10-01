using CurlingRinkManagement.Base.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurlingRinkManagement.Base.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController(ILogger<AuthController> logger) : ControllerBase
    {
        private readonly ILogger<AuthController> _logger = logger;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new AuthenticationModel() { UserId = Guid.Empty, Role = Role.Admin});
        }
    }
}
