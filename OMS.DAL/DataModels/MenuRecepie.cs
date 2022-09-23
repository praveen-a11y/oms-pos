using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class MenuRecepie
    {
        public long RecepieId { get; set; }
        public long MenuId { get; set; }
        public long ItemId { get; set; }
        public decimal Quantity { get; set; }
    }
}
