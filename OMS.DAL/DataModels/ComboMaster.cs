using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ComboMaster
    {
        public long ComboId { get; set; }
        public string ComboCode { get; set; } = null!;
        public string ComboName { get; set; } = null!;
        public string ComboDescription { get; set; } = null!;
        public DateTime ComboStartDate { get; set; }
        public DateTime ComboEndDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ItemCategoryId { get; set; }
    }
}
