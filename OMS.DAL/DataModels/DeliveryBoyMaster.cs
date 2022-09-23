using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class DeliveryBoyMaster
    {
        public long DeliveryBoyId { get; set; }
        public string DeliveryBoyName { get; set; } = null!;
        public string? ContactNo { get; set; }
        public long OutletId { get; set; }
        public long? UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
