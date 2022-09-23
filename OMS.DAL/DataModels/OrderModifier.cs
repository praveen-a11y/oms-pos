using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OrderModifier
    {
        public long OrderModifierId { get; set; }
        public long OrderDetailId { get; set; }
        public long ModifierDeatilId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; } = null!;
    }
}
