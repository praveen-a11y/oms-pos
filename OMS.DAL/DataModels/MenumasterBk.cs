using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class MenumasterBk
    {
        public long MenuId { get; set; }
        public long ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string ItemName { get; set; } = null!;
        public string? Barcode { get; set; }
        public long UnitId { get; set; }
        public string DisplayName { get; set; } = null!;
        public decimal RecipeStanderdQty { get; set; }
        public string? ItemDescription { get; set; }
        public string ItemType { get; set; } = null!;
        public long ItemCategoryId { get; set; }
        public bool? IsServedHot { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsDiscountable { get; set; }
        public bool? IsFractionable { get; set; }
        public decimal? ItemPrice { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string? WebSku { get; set; }
        public string? WebUom { get; set; }
        public bool? IsWebActive { get; set; }
        public byte[]? ItemImage { get; set; }
        public string? Webuse { get; set; }
        public string? WebUkm { get; set; }
        public string? ItemImageName { get; set; }
        public byte[]? ItemImageBk { get; set; }
    }
}
