using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ItemCategoryMasterBackup
    {
        public long ItemCategoryId { get; set; }
        public string ItemCategoryPrefix { get; set; } = null!;
        public string ItemCategoryName { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public long? ModifiedBy { get; set; }
        public string? LedgerNameForMrntally { get; set; }
    }
}
