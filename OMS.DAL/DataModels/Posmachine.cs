using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class Posmachine
    {
        public decimal PosmachinesId { get; set; }
        public string PosmachineName { get; set; } = null!;
        public string? PosmachineCode { get; set; }
        public string? PosmachineDescription { get; set; }
        public decimal DivisionId { get; set; }
        public decimal OutletId { get; set; }
        public bool IsInUse { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
