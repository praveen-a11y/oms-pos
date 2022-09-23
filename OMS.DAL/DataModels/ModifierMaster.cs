using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ModifierMaster
    {
        public long ModifierId { get; set; }
        public string ModifierName { get; set; } = null!;
        public decimal? ModifierCharges { get; set; }
        public string? ModifierDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
