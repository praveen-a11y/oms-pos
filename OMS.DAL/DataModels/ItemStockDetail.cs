using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ItemStockDetail
    {
        public long StockId { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public decimal IssueQuantity { get; set; }
        public decimal? StockAdjustmentValue { get; set; }
        public string TransactionType { get; set; } = null!;
        public long TransactionId { get; set; }
        public string Remarks { get; set; } = null!;
        public DateTime TransactionDateTime { get; set; }
    }
}
