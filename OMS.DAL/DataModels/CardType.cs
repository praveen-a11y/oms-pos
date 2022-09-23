using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class CardType
    {
        public long CardTypeId { get; set; }
        public string CardTypeName { get; set; } = null!;
        public string CardTypeDescription { get; set; } = null!;
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
