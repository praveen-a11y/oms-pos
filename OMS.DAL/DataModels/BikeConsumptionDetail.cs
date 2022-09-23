using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class BikeConsumptionDetail
    {
        public long BikeConsumptionId { get; set; }
        public long? DeliveryBoyId { get; set; }
        public DateTime? ConsumptionDate { get; set; }
        public decimal? BikeId { get; set; }
        public int? MeterReadingFrom { get; set; }
        public int? MeterReadingTo { get; set; }
        public decimal? RatePerKg { get; set; }
        public string? Remarks { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDispatchClosed { get; set; }
        public long? OutletId { get; set; }
    }
}
