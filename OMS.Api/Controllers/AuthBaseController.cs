using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace OMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthBaseController : ControllerBase
    {
        public Guid UserId { get; set; }
        public AuthBaseController(IHttpContextAccessor httpContextAccessor)
        {
            UserId = Guid.Parse(httpContextAccessor.HttpContext.User.Identity.Name);
        }
    }
}
