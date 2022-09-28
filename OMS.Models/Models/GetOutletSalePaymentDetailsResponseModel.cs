using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class GetOutletSalePaymentDetailsResponseModel
    {
        public string? PaymentTypeName { get; set; }
        public decimal NetSales { get; set; }
    }
}
