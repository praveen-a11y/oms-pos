using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class LoyaltyProgrammeItem
    {
        public int ProgrammeItemId { get; set; }
        public int? ProgrammId { get; set; }
        public int? ItemId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string? Day { get; set; }
        public decimal? MaxAmount { get; set; }
    }
}
