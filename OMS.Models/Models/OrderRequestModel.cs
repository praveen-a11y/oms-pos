using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class OrderRequestModel
    {
        public string OrderType { get; set; }
        public string Kot { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerAddress { get; set; }
        public float DiscountPer { get; set; }  
        public string DiscountDesc { get; set; }
        public IEnumerable<OrderRequestItemModel> OrderRequestItem { get; set; }
        public IEnumerable<OrderRequestPaymentModel> RequestPaymentDetails { get; set; }
        public Guid CreatedById { get; set; }
             
    }
}
