using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string? StatusCode { get; set; }
    }
}
