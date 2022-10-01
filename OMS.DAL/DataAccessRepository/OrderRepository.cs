using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OMS.DAL.DataModels;
using OMS.DAL.IDataAccessRepository;
using OMS.Models;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataAccessRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OMSContext _dbContext = null;
        private readonly IMapper _mapper;
        public OrderRepository(OMSContext oMSContext, IMapper mapper)
        {
            _dbContext = oMSContext;
            _mapper = mapper;
        }
        public OrderResponseModel OrderPlacement(OrderRequestModel orderRequestModel)
        {
            OrderResponseModel orderResponse = new OrderResponseModel();
            var tblOrderRequestItem = new DataTable();
            tblOrderRequestItem.Columns.Add("ItemID");
            tblOrderRequestItem.Columns.Add("Quantity");
            foreach (var item in orderRequestModel.OrderRequestItem)
            {
                tblOrderRequestItem.Rows.Add(item.ItemID, item.Quantity);
            }

            var tblRequestPaymentDetails = new DataTable();
            tblRequestPaymentDetails.Columns.Add("PaymentTypedId");
            tblRequestPaymentDetails.Columns.Add("PaymentTyped");
            tblRequestPaymentDetails.Columns.Add("Amount");
            foreach (var payment in orderRequestModel.RequestPaymentDetails)
            {
                tblRequestPaymentDetails.Rows.Add(payment.PaymentTypeId, payment.PaymentTypeId, payment.Amount);
            }
            var paramStringProcedureStatus = new SqlParameter()
            {
                ParameterName = "@StringProcedureStatus",
                SqlDbType = SqlDbType.BigInt,
                Direction = ParameterDirection.Output,
            };

            var paramOrderType = new SqlParameter("@OrderType", orderRequestModel.OrderType);
            var paramIsKOT = new SqlParameter("@IsKOT", false);
            var paramCustomerName = new SqlParameter("@CustomerName", orderRequestModel.CustomerName);
            var paramMobileNo = new SqlParameter("@MobileNo", orderRequestModel.CustomerMobile);
            var paramAddress = new SqlParameter("@Address", orderRequestModel.CustomerAddress);
            var paramDiscountPer = new SqlParameter("@DiscountPer", orderRequestModel.DiscountPer);
            var paramDiscountReason = new SqlParameter("@DiscountReason", orderRequestModel.DiscountDesc);

            var paramCartItems = new SqlParameter("@CartItems", SqlDbType.Structured)
            {
                Value = tblOrderRequestItem,
                TypeName = "[dbo].[tblCartItems]"
            };

            var paramtblCartPaymentDtl = new SqlParameter("@tblCartPaymentDtl", SqlDbType.Structured)
            {
                Value = tblRequestPaymentDetails,
                TypeName = "[dbo].[tblCartPaymentDetails]"
            };

            var paramCreatedBy = new SqlParameter("@CreatedBy", SqlDbType.UniqueIdentifier)
            {
                Value = orderRequestModel.CreatedById,
            };


            var res = _dbContext.OrderResponse.FromSqlRaw("EXEC sp_OrderPlacement @OrderType,@IsKOT,@CustomerName,@MobileNo,@Address,@DiscountPer,@DiscountReason,@CartItems,@tblCartPaymentDtl,@CreatedBy",
                paramOrderType, paramIsKOT, paramCustomerName, paramMobileNo, paramAddress, paramDiscountPer, paramDiscountReason, paramCartItems, paramtblCartPaymentDtl, paramCreatedBy).AsEnumerable().FirstOrDefault();
            if (res != null)
                orderResponse = res;

            return orderResponse;
        }

        public CommonSpResponseModel UpdateOrderVoid(OrderUpdateRequestModel requestModel)
        {
            CommonSpResponseModel responseModel = null;
            UserViewModel usermodel = new UserViewModel();
            var outletIdParam = new SqlParameter("@OutletId", requestModel.OutletId);
            var orderIdParam = new SqlParameter("@OrderId", requestModel.OrderId);
            var voidReasonParam = new SqlParameter("@VoidReason", requestModel.Comment);
            var paramCreatedBy = new SqlParameter("@UserId", SqlDbType.UniqueIdentifier)
            {
                Value = requestModel.UserId,
            };

            var result = _dbContext.CommonSpResponses
            .FromSqlRaw("exec UpdateOrderVoid @OutletId, @OrderId, @VoidReason, @UserId", outletIdParam, orderIdParam, voidReasonParam ,paramCreatedBy).AsEnumerable();

            responseModel = _mapper.Map<CommonSpResponseModel>(result.FirstOrDefault());

            return responseModel;
        }

        private static SqlParameter[] BuildOrderParams(OrderRequestModel orderRequestModel)
        {
            var tblOrderRequestItem = new DataTable();
            tblOrderRequestItem.Columns.Add("ItemID");
            tblOrderRequestItem.Columns.Add("Quantity");
            foreach (var item in orderRequestModel.OrderRequestItem)
            {
                tblOrderRequestItem.Rows.Add(item.ItemID, item.Quantity);
            }

            var tblRequestPaymentDetails = new DataTable();
            tblRequestPaymentDetails.Columns.Add("PaymentTypedId");
            tblRequestPaymentDetails.Columns.Add("PaymentTyped");
            tblRequestPaymentDetails.Columns.Add("Amount");
            foreach (var payment in orderRequestModel.RequestPaymentDetails)
            {
                tblRequestPaymentDetails.Rows.Add(null, payment.PaymentTypeId, payment.Amount);
            }
            var stringProcedureStatus = new SqlParameter()
            {
                ParameterName = "@StringProcedureStatus",
                SqlDbType = SqlDbType.BigInt,
                Direction = ParameterDirection.Output,
            };

            SqlParameter[] paramaters = { new SqlParameter("@OrderType", orderRequestModel.OrderType),
            new SqlParameter("@IsKOT", false),
            new SqlParameter("@CustomerName", orderRequestModel.CustomerName),
            new SqlParameter("@MobileNo", orderRequestModel.CustomerMobile),
            new SqlParameter("@Address", orderRequestModel.CustomerAddress),
            new SqlParameter("@DiscountPer", orderRequestModel.DiscountPer),
            new SqlParameter("@DiscountReason", orderRequestModel.DiscountDesc),

            new SqlParameter("@CartItems", SqlDbType.Structured) {
                Value = tblOrderRequestItem,
            TypeName = "dbo.tblCartItems"},

            new SqlParameter("@tblCartPaymentDtl", SqlDbType.Structured) {
                Value = tblRequestPaymentDetails,
            TypeName = "dbo.tblCartPaymentDetails"        },

            new SqlParameter("@CreatedBy", SqlDbType.UniqueIdentifier)
            {
                Value = orderRequestModel.CreatedById,
            }   
            };
            return paramaters;
        }
    }
}
