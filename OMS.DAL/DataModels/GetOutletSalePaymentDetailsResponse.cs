using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataModels
{
    public class GetOutletSalePaymentDetailsResponse
    {
        [Key]
        public string? PaymentTypeName { get; set; }
        public decimal NetSales { get; set; }            

    }
}
