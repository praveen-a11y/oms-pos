using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class CityMaster
    {
        public long CityId { get; set; }
        public string CityName { get; set; } = null!;
        public long StateId { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
