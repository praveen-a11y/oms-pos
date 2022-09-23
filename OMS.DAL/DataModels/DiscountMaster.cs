using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class DiscountMaster
    {
        public long DiscountId { get; set; }
        public string DiscountCode { get; set; } = null!;
        public string DiscountName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal DiscountAmount { get; set; }
        public decimal Percentage { get; set; }
        public string? DiscountType { get; set; }
        public bool IsOnItem { get; set; }
        public bool? IsOnOrder { get; set; }
        public decimal? OrderMinAmount { get; set; }
        public decimal? OrderMaxAmount { get; set; }
        public bool IsComboDiscount { get; set; }
        public bool IsOnlineDiscount { get; set; }
        public bool IsActive { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
