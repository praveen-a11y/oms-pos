using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class TaxMaster
    {
        public long TaxId { get; set; }
        public string TaxType { get; set; } = null!;
        public string? TaxDescription { get; set; }
        public decimal TaxPercent { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
