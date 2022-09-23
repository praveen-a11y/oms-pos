using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class TillDenominationsDetail
    {
        public long TilldenominationsDetailId { get; set; }
        public long TillManagementMasterId { get; set; }
        public string DenominationName { get; set; } = null!;
        public decimal DenominationValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
