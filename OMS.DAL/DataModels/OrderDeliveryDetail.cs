using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OrderDeliveryDetail
    {
        public long OrderDeliveryDetailId { get; set; }
        public long OrderId { get; set; }
        public long DeliveryBoyId { get; set; }
        public string MeterReading { get; set; } = null!;
        public string Remarks { get; set; } = null!;
        public DateTime TranactionDate { get; set; }
        public long BikeConsumptionId { get; set; }
    }
}
