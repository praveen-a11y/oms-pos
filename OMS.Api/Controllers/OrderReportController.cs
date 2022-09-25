using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMS.BLL.IBusinessComponent;
using OMS.Models.Models;

namespace OMS.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderReportController : ControllerBase
    {
        private readonly IOrderReportComponent _orderReportComponent = null;

        public OrderReportController(IOrderReportComponent orderReportComponent)
        {
            _orderReportComponent = orderReportComponent;
        }

        //public OrderReportController(IHttpContextAccessor httpContextAccessor, IOrderReportComponent orderReportComponent) : base(httpContextAccessor)
        //{
        //    _orderReportComponent = orderReportComponent;
        //}

        [HttpPost("GetOutletOrderList")]
        public IActionResult GetOutletOrderList(OrderReportRequestModel reportRequestModel)
        {
            return Ok(_orderReportComponent.GetOutletOrderList(reportRequestModel));
        }

        [HttpPost("GetOuteltItemWiseOrderDetail")]
        public IActionResult GetOuteltItemWiseOrderDetail(OrderReportRequestModel reportRequestModel)
        {
            return Ok(_orderReportComponent.GetOuteltItemWiseOrderDetail(reportRequestModel));
        }

        [HttpPost("GetOuteltItemDetailSummary")]
        public IActionResult GetOuteltItemDetailSummary(OrderReportRequestModel reportRequestModel)
        {
            return Ok(_orderReportComponent.GetOuteltItemDetailSummary(reportRequestModel));
        }
    }
}
