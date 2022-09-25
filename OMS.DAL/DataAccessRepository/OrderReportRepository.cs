using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OMS.DAL.DataModels;
using OMS.DAL.IDataAccessRepository;
using OMS.Models;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataAccessRepository
{
    public class OrderReportRepository : IOrderReportRepository
    {
        private readonly OMSContext _dbContext = null;
        private readonly IMapper _mapper;
        public OrderReportRepository(OMSContext oMSContext, IMapper mapper)
        {
            _dbContext = oMSContext;
            _mapper = mapper;
        }

        public IEnumerable<GetOutletOrderListResponseModel> GetOutletOrderList(OrderReportRequestModel requestModel)
        {
            IEnumerable<GetOutletOrderListResponseModel> getOuteltItemDetails = null;
            UserViewModel usermodel = new UserViewModel();
            var outletIdParam = new SqlParameter("@OutletId", requestModel.OutletId);
            var fromDateParam = new SqlParameter("@FromDate", requestModel.FromDate);
            var toDateParam = new SqlParameter("@ToDate", requestModel.ToDate);

            var result = _dbContext.GetOutletOrderList
            .FromSqlRaw("exec GETOutletOrderList @OutletId, @FromDate, @ToDate", outletIdParam, fromDateParam, toDateParam).AsEnumerable();

            getOuteltItemDetails = _mapper.Map<IEnumerable<GetOutletOrderListResponseModel>>(result);

            return getOuteltItemDetails;
        }

        public IEnumerable<GetOuteltItemWiseOrderDetailNewResponseModel> GetOuteltItemWiseOrderDetail(OrderReportRequestModel requestModel)
        {
            IEnumerable<GetOuteltItemWiseOrderDetailNewResponseModel> getOuteltItemWiseOrderDetailNews = null;
            UserViewModel usermodel = new UserViewModel();
            var outletIdParam = new SqlParameter("@OutletId", requestModel.OutletId);
            var fromDateParam = new SqlParameter("@FromDate", requestModel.FromDate);
            var toDateParam = new SqlParameter("@ToDate", requestModel.ToDate);

            var result = _dbContext.GetOuteltItemWiseOrderDetails
            .FromSqlRaw("exec GETOuteltItemWiseOrderDetail_New @OutletId, @FromDate, @ToDate", outletIdParam, fromDateParam, toDateParam).AsEnumerable();

            getOuteltItemWiseOrderDetailNews = _mapper.Map<IEnumerable<GetOuteltItemWiseOrderDetailNewResponseModel>>(result);

            return getOuteltItemWiseOrderDetailNews;
        }


        public IEnumerable<GetOuteltItemDetailSummaryResponseModel> GetOuteltItemDetailSummary(OrderReportRequestModel requestModel)
        {
            IEnumerable<GetOuteltItemDetailSummaryResponseModel> getOuteltItemDetailSummaries = null;
            UserViewModel usermodel = new UserViewModel();
            var outletIdParam = new SqlParameter("@OutletId", requestModel.OutletId);
            var fromDateParam = new SqlParameter("@FromDate", requestModel.FromDate);
            var toDateParam = new SqlParameter("@ToDate", requestModel.ToDate);

            var result = _dbContext.GetOuteltItemDetailSummary
            .FromSqlRaw("exec GETOuteltItemDetailSummary @OutletId, @FromDate, @ToDate", outletIdParam, fromDateParam, toDateParam).AsEnumerable();

            getOuteltItemDetailSummaries = _mapper.Map<IEnumerable<GetOuteltItemDetailSummaryResponseModel>>(result);

            return getOuteltItemDetailSummaries;
        }




    }
}
