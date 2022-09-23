using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class BikeMaster
    {
        public long BikeId { get; set; }
        public string? BikeCode { get; set; }
        public string? BikeNumer { get; set; }
        public string? BikeModel { get; set; }
        public string? BikeColor { get; set; }
        public int? InitialMeterReading { get; set; }
        public bool? IsInUse { get; set; }
        public bool? IsBikeOut { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? OutletId { get; set; }
    }
}
