using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OrderComboDetail
    {
        public long OrderComboDetailId { get; set; }
        public long OrderId { get; set; }
        public long ComboId { get; set; }
        public long ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Amount { get; set; }
    }
}
