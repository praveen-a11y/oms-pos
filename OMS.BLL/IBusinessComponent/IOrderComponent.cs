using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL.IBusinessComponent
{
    public interface IOrderComponent
    {
        OrderResponseModel OrderPlacement(OrderRequestModel orderRequestModel);
        CommonSpResponseModel UpdateOrderVoid(OrderUpdateRequestModel requestModel);
    }
}
