using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ItemStock
    {
        public long StockId { get; set; }
        public long ItemId { get; set; }
        public long OutletId { get; set; }
        public decimal OpeningStock { get; set; }
        public decimal OpeningValue { get; set; }
        public decimal ClosingStock { get; set; }
        public decimal ClosingValue { get; set; }
    }
}
