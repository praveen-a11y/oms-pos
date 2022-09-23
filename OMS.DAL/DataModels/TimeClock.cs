using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class TimeClock
    {
        public decimal TimeClockId { get; set; }
        public decimal EmpId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public string ClockType { get; set; } = null!;
        public decimal? ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? ShiftDate { get; set; }
    }
}
