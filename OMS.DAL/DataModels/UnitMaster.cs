using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class UnitMaster
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
