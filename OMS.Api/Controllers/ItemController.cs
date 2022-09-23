using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMS.BLL.IBusinessComponent;

namespace OMS.Api.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : AuthBaseController
    {
        private readonly IItemComponent _itemComponent = null;
        public ItemController(IHttpContextAccessor httpContextAccessor, IItemComponent itemComponent) : base(httpContextAccessor)
        {
            _itemComponent = itemComponent;
        }

        [HttpGet("GetItems")]
        public IActionResult GetItems(long outletId)
        {
            return Ok(_itemComponent.GetItems(outletId));
        }
    }
}
