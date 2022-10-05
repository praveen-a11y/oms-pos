using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataModels
{
    public class GetOuteltItemDetailSummaryResponse
    {
        [Key]
        public long ItemID { get; set; }
        public string? ItemCategoryName { get; set; }
        public string? ItemName { get; set; }
        public decimal? Sale { get; set; }
    }
}
