using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ShiftMaster
    {
        public long ShiftId { get; set; }
        public string ShiftName { get; set; } = null!;
        public string ShiftDescription { get; set; } = null!;
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
