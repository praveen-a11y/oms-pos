using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class FinancialYear
    {
        public long FinancialYearId { get; set; }
        public string FinancialYear1 { get; set; } = null!;
        public string FinancialYearPrefix { get; set; } = null!;
    }
}
