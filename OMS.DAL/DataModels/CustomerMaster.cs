using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class CustomerMaster
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public decimal MobileNo { get; set; }
        public string? ContactNo { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? LandMark { get; set; }
        public long? ZoneId { get; set; }
        public long CityId { get; set; }
        public string? PasswordOnline { get; set; }
        public DateTime? RegisterdDate { get; set; }
        public bool? IsVerififed { get; set; }
        public string? Otp { get; set; }
        public string? Source { get; set; }
        public string? FacebookId { get; set; }
        public string? GoogleId { get; set; }
        public string? City { get; set; }
        public int? Pincode { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string? Remarks { get; set; }
    }
}
