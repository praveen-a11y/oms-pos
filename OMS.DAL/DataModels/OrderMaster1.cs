using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OrderMaster1
    {
        public long OrderId { get; set; }
        public long OutletOrderNo { get; set; }
        public long? OffOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OutletId { get; set; }
        public string? BillNumber { get; set; }
        public long Kot { get; set; }
        public int? NoOfGuest { get; set; }
        public int? NoOfExtraChair { get; set; }
        public long? TableId { get; set; }
        public DateTime? BookingTimeFrom { get; set; }
        public DateTime? BookingTimeTo { get; set; }
        public string TaxDescription { get; set; } = null!;
        public long TaxId { get; set; }
        public string? DiscountDescription { get; set; }
        public long? DiscountId { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal? CustomerPay { get; set; }
        public decimal? ChangeGiven { get; set; }
        public string? CustomerName { get; set; }
        public string OrderType { get; set; } = null!;
        public string OrderSource { get; set; } = null!;
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDateDt { get; set; }
        public string Status { get; set; } = null!;
        public long? FinancialYearId { get; set; }
        public long? CustomerId { get; set; }
        public bool? IsVoid { get; set; }
    }
}
