using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class GetOuteltItemWiseOrderDetailNewResponseModel
    {
        public long SrNo { get; set; }
        public string? OrderSource { get; set; }
        public string? OrderType { get; set; }
        public string? BillNo { get; set; }
        public DateTime? Date { get; set; }
        public string? Category { get; set; }
        public string? Item { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ItemAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? GST { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
