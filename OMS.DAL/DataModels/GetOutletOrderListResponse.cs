using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataModels
{
    public class GetOutletOrderListResponse
    {
        public string OrderBy { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderSource { get; set; }
        [Key]
        public long OrderNo { get; set; }
        public string? OrderStatus { get; set; }
        public decimal OrderAmount { get; set; }
        public string? PaymentMode { get; set; }
        public string? Reason { get; set; }

    }
}
