using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class StateMaster
    {
        public long StateId { get; set; }
        public string StateName { get; set; } = null!;
        public long CountryId { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
