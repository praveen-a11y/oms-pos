using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ZoneMaster
    {
        public long ZoneId { get; set; }
        public string ZoneName { get; set; } = null!;
        public string? ZoneDescription { get; set; }
        public long OutletId { get; set; }
        public long CityId { get; set; }
        public bool IsActive { get; set; }
        public long? CreatededBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
