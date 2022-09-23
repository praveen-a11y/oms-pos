using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OrderSettlementDetailTest
    {
        public long OrderSettlementDetailId { get; set; }
        public long OrderId { get; set; }
        public long OutletId { get; set; }
        public long PaymentTypeId { get; set; }
        public decimal Amount { get; set; }
        public string? CardHolder { get; set; }
        public string? CardType { get; set; }
        public int? CardNo { get; set; }
        public DateTime? CardExpiryDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Remarks { get; set; }
    }
}
