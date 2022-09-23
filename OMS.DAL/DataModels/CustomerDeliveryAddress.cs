using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class CustomerDeliveryAddress
    {
        public long AddressId { get; set; }
        public long CustomerId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Landmark { get; set; }
        public long? CityId { get; set; }
        public long? ZoneId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }
    }
}
