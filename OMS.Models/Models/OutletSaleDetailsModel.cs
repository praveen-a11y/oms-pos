using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class OutletSaleDetailsModel
    {
        public IEnumerable<GetOutletSaleDetailsResponseModel> OutletSaleDetails { get; set; }
        public IEnumerable<GetOutletSalePaymentDetailsResponseModel> OutletSalePaymentDetails { get; set; }
    }
}
