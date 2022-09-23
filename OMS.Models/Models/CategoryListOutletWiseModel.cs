using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class CategoryListOutletWiseModel
    {
        public long OutletId { get; set; }
        public long ItemCategoryId { get; set; }
        public string? ItemCategoryName { get; set; }

        public IEnumerable<ItemListOutletWiseModel> Items { get; set; }
    }
}
