using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class UserMaster
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? EmployeeCode { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public bool IsActive { get; set; }
        public long OutletId { get; set; }
        public long? DepartmentId { get; set; }
        public long? UserHeadId { get; set; }
        public bool? IsDiscount { get; set; }
    }
}
