using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class CustomerDetail
    {
        public decimal CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public long MobileNo { get; set; }
        public string Address { get; set; } = null!;
        public string? Description { get; set; }
        public decimal OrderId { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Reamarks { get; set; }
    }
}
