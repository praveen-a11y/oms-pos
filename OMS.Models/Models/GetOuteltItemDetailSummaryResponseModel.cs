using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class GetOuteltItemDetailSummaryResponseModel
    {

        public long ItemID { get; set; }
        public string? ItemCategoryName { get; set; }
        public string? ItemName { get; set; }
        public decimal? Sale { get; set; }
    }
}
