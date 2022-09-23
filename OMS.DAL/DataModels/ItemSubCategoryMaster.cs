using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ItemSubCategoryMaster
    {
        public long ItemSubCategoryId { get; set; }
        public long ItemCategoryId { get; set; }
        public string ItemSubCategoryPrefix { get; set; } = null!;
        public string ItemSubCategoryName { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public long? ModifiedBy { get; set; }
        public string? CategoryImage { get; set; }
    }
}
