using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class ItemListOutletWiseModel
    {
        public long ItemCategoryId { get; set; } 
        public long ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? TaxPercent { get; set; }
    }
}
