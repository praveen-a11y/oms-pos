using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataModels
{
    public class GetOutletSaleDetailsResponse
    {
        [Key]        
        public string? OrderType { get; set; }
        public decimal NetSale { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal GST { get; set; }

    }
}
