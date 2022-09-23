using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class PaymentTypeMaster
    {
        public long PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; } = null!;
        public string PaymentTypeDescription { get; set; } = null!;
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsOpenCashDrawer { get; set; }
        public bool IsCardInfoRequired { get; set; }
    }
}
