using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class TillStatus
    {
        public long TillStatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string StatusDescription { get; set; } = null!;
    }
}
