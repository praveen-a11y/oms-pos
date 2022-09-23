using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ModifierDetail
    {
        public long ModifierDetailId { get; set; }
        public long ItemId { get; set; }
        public long ModifierId { get; set; }
    }
}
