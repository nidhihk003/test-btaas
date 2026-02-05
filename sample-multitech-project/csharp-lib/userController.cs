using Microsoft.AspNetCore.Mvc;

namespace DummyApp.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _service.GetUser(id);
            return Ok(user);
        }
    }
}
