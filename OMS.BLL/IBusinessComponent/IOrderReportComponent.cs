using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL.IBusinessComponent
{
    public interface IOrderReportComponent
    {
        IEnumerable<GetOutletOrderListResponseModel> GetOutletOrderList(OrderReportRequestModel requestModel);
        IEnumerable<GetOuteltItemWiseOrderDetailNewResponseModel> GetOuteltItemWiseOrderDetail(OrderReportRequestModel requestModel);
        IEnumerable<GetOuteltItemDetailSummaryResponseModel> GetOuteltItemDetailSummary(OrderReportRequestModel requestModel);
        OutletSaleDetailsModel GetOuteltSaleDetails(OrderReportRequestModel requestModel);
    }
}
