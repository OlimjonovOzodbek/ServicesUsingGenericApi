using JWTRepeat.Application.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace JWTRepeat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService _uS;

        public UserController(IUserService uS)
        {
            _uS = uS;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _uS.GetAll());
        }
    }
}
