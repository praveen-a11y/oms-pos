using AutoMapper;
using OMS.DAL.DataModels;
using OMS.Models;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataAccessRepository
{
    public class Profiles: Profile
    {
        public Profiles()
        {
            CreateMap<ItemListOutletCategoryWise, ItemListOutletCategoryWiseModel>();
            CreateMap<GetOutletOrderListResponse, GetOutletOrderListResponseModel>();
            CreateMap<GetOuteltItemWiseOrderDetailNewResponse, GetOuteltItemWiseOrderDetailNewResponseModel>();
            CreateMap<GetOuteltItemDetailSummaryResponse, GetOuteltItemDetailSummaryResponseModel>();
            CreateMap<GetOutletSaleDetailsResponse, GetOutletSaleDetailsResponseModel>();
            CreateMap<GetOutletSalePaymentDetailsResponse, GetOutletSalePaymentDetailsResponseModel>();
        }
    }
}
