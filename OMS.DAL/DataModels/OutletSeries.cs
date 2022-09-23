using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OutletSeries
    {
        public long FinancialYearId { get; set; }
        public string OutletPrefix { get; set; } = null!;
        public long OutletId { get; set; }
        public long NextNumber { get; set; }
        public long OrderNo { get; set; }
        public string? TransactionType { get; set; }
    }
}
