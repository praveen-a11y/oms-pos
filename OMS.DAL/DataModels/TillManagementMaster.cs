using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class TillManagementMaster
    {
        public decimal TillManagementId { get; set; }
        public long PosmachinesId { get; set; }
        public long TillStatus { get; set; }
        public decimal OpeningAmount { get; set; }
        public decimal? TillDenominationsTotalAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? Variance { get; set; }
        public string? VarianceReason { get; set; }
        public DateTime? BusinessDateDatetime { get; set; }
        public int UserId { get; set; }
    }
}
