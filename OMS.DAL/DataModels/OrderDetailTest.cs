using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OrderDetailTest
    {
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public long ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal NetAmount { get; set; }
        public decimal ModifierTotalAmount { get; set; }
        public string DiscountDescription { get; set; } = null!;
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public string TaxDescription { get; set; } = null!;
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsVoid { get; set; }
        public string Remarks { get; set; } = null!;
        public DateTime TranactionDate { get; set; }
        public long ComboId { get; set; }
        public bool IsHot { get; set; }
        public decimal Cgstpercentage { get; set; }
        public decimal Cgstamount { get; set; }
        public decimal Sgstpercentage { get; set; }
        public decimal Sgstamount { get; set; }
        public decimal Utgstpercentage { get; set; }
        public decimal Utgstamount { get; set; }
        public decimal Igstpercentage { get; set; }
        public decimal Igstamount { get; set; }
        public long? OutletId { get; set; }
        public decimal? UnitGstPrice { get; set; }
    }
}
