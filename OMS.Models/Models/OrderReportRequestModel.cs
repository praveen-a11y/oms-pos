using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class OrderReportRequestModel
    {
        public long OutletId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
}
