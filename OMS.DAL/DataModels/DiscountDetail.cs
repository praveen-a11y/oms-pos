using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class DiscountDetail
    {
        public long DiscountDetailId { get; set; }
        public long DiscountId { get; set; }
        public long ItemId { get; set; }
        public long OutletId { get; set; }
    }
}
