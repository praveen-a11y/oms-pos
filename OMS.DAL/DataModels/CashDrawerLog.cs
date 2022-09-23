using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class CashDrawerLog
    {
        public long CashDrawerLogId { get; set; }
        public long OrderId { get; set; }
        public string Remarks { get; set; } = null!;
        public long UserId { get; set; }
        public DateTime CashDrawerOpenTime { get; set; }
        public decimal OutletId { get; set; }
    }
}
