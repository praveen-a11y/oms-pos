using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class LoyaltyProgramme
    {
        public int ProgrammId { get; set; }
        public string? ProgrammeName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public long? StatusId { get; set; }
    }
}
