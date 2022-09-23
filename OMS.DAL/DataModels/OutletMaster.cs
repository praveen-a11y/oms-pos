using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class OutletMaster
    {
        public long OutletId { get; set; }
        public string OutletName { get; set; } = null!;
        public string DispalyOutletName { get; set; } = null!;
        public string? NewName { get; set; }
        public long CityId { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        public bool? IsDineIn { get; set; }
        public bool? IsTakeAway { get; set; }
        public bool? IsHomeDelivery { get; set; }
        public bool? IsPosused { get; set; }
        public string? BillNumberPrefix { get; set; }
        public string? Tinno { get; set; }
        public bool? Isclosed { get; set; }
        public bool? IsFranchise { get; set; }
        public long? StateId { get; set; }
    }
}
