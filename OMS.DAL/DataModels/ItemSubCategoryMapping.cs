using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ItemSubCategoryMapping
    {
        public long? ItemCategoryId { get; set; }
        public long? OutletId { get; set; }
    }
}
