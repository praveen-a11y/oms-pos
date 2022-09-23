using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class ItemBarCode
    {
        public decimal ItemBarCodeId { get; set; }
        public decimal MenuId { get; set; }
        public decimal ItemId { get; set; }
        public string? ItemBarCode1 { get; set; }
        public decimal Price1 { get; set; }
        public decimal Price2 { get; set; }
        public decimal Price3 { get; set; }
        public decimal Price4 { get; set; }
        public decimal Price5 { get; set; }
        public decimal OutletId { get; set; }
        public bool? IsApplicableToPos { get; set; }
        public bool? IsApplicableToHd { get; set; }
    }
}
