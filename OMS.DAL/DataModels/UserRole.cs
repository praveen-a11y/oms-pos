using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class UserRole
    {
        public long RoleId { get; set; }
        public long UserId { get; set; }
        public long FormId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
