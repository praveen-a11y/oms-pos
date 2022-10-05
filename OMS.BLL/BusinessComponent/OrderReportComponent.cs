using OMS.BLL.IBusinessComponent;
using OMS.DAL.IDataAccessRepository;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL.BusinessComponent
{
    public class OrderReportComponent : IOrderReportComponent
    {
        private readonly IOrderReportRepository  _orderReportRepository;
        public OrderReportComponent(IOrderReportRepository orderReportRepository)
        {
            _orderReportRepository = orderReportRepository;
        }

        public IEnumerable<GetOuteltItemDetailSummaryResponseModel> GetOuteltItemDetailSummary(OrderReportRequestModel requestModel)
        {
            return _orderReportRepository.GetOuteltItemDetailSummary(requestModel);
        }

        public IEnumerable<GetOuteltItemWiseOrderDetailNewResponseModel> GetOuteltItemWiseOrderDetail(OrderReportRequestModel requestModel)
        {
            return _orderReportRepository.GetOuteltItemWiseOrderDetail(requestModel);
        }

        public IEnumerable<GetOutletOrderListResponseModel> GetOutletOrderList(OrderReportRequestModel requestModel)
        {
            return _orderReportRepository.GetOutletOrderList(requestModel);
        }

        public OutletSaleDetailsModel GetOuteltSaleDetails(OrderReportRequestModel requestModel)
        {
            OutletSaleDetailsModel outletSaleDetails = new OutletSaleDetailsModel();

            outletSaleDetails.OutletSaleDetails = _orderReportRepository.GetOuteltSaleDetails(requestModel);
            outletSaleDetails.OutletSalePaymentDetails = _orderReportRepository.GetOuteltSalePaymentDetails(requestModel);
            _orderReportRepository.GetOuteltSaleDetails(requestModel);

            return outletSaleDetails;
        }

    }
}
