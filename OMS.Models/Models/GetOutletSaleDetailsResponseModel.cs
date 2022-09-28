using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class GetOutletSaleDetailsResponseModel
    {
        public string? OrderSource { get; set; }
        public decimal NetSale { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal GST { get; set; }
    }
}
