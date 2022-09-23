using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class ItemListOutletCategoryWiseModel
    {
        public long OutletId { get; set; }
        public string OutletName { get; set; }
        public long ItemCategoryId { get; set; }
        public string? ItemCategoryName { get; set; }
        public long? MenuID { get; set; }
        public long ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? TaxPercent { get; set; }        
        public decimal? OpeningStock { get; set; }
        public decimal? ClosingStock { get; set; }
    }
}
