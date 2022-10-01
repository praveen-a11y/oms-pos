using Microsoft.AspNetCore.Mvc;
using OMS.BLL.IBusinessComponent;
using OMS.Models.Models;

namespace OMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : AuthBaseController
    {
        private readonly IOrderComponent _orderComponent = null;
        public OrderController(IOrderComponent orderComponent, IHttpContextAccessor httpContextAccessor): base(httpContextAccessor)
        {
            _orderComponent = orderComponent;
        }

        [HttpPost("Save")]
        public IActionResult Save(OrderRequestModel orderRequestModel)
        {
            orderRequestModel.CreatedById = UserId;
            return Ok(_orderComponent.OrderPlacement(orderRequestModel));
        }
        
        [HttpPost("Cancel")]
        public IActionResult UpdateOrderVoid(OrderUpdateRequestModel requestModel)
        {
            requestModel.UserId = UserId;
            return Ok(_orderComponent.UpdateOrderVoid(requestModel));
        }
    }
}
