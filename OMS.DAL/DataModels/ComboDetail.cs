using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ComboDetail
    {
        public long ComboDetailId { get; set; }
        public long ComboId { get; set; }
        public long MenuId { get; set; }
        public long ItemId { get; set; }
        public decimal QuantityNo { get; set; }
        public decimal QuantityKg { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ComboPrice { get; set; }
        public long StateId { get; set; }
        public long DiscountId { get; set; }
        public long? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
