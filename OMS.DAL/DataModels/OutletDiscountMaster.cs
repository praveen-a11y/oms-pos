using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OutletDiscountMaster
    {
        public int OutletDiscountId { get; set; }
        public int OutletId { get; set; }
        public decimal DisPercentage { get; set; }
    }
}
