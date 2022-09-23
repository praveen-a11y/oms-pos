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
    public class OrderComponent : IOrderComponent
    {
        private readonly IOrderRepository _orderRepository = null;

        public OrderComponent(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public OrderResponseModel OrderPlacement(OrderRequestModel orderRequestModel)
        {
            return _orderRepository.OrderPlacement(orderRequestModel);
        }
    }
}
