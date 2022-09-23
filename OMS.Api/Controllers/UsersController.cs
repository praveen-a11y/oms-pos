using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMS.Api.Services;
using OMS.BLL.IBusinessComponent;
using OMS.Models.Models;

namespace OMS.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserAuthService _userAuthService = null;
        private readonly IUserComponent userComponent;
        public UsersController(IUserAuthService _userAuthService)
        {
            this._userAuthService = _userAuthService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserLoginInputModel model)
        {
            var response = _userAuthService.Authenticate(model);
            if (response == null)
                return BadRequest(response);

            return Ok(response);
        }


    }
}


