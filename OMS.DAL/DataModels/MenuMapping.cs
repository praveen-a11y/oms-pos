using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class MenuMapping
    {
        public long MappingId { get; set; }
        public long Outletid { get; set; }
        public long MenuId { get; set; }
        public long ItemId { get; set; }
        public decimal NetPrice { get; set; }
        public decimal ProcessedNetPrice { get; set; }
        public long TaxId { get; set; }
        public bool IsHomeDelivery { get; set; }
        public bool IsDineIn { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDinnerOrDeli { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long ServiceTaxId { get; set; }
        public bool IsServiceTaxApplied { get; set; }
        public string ServiceTaxApplicableOnCh { get; set; } = null!;
    }
}
