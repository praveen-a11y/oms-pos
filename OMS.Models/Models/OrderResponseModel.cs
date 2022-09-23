using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class OrderResponseModel
    {
        [Key]
        public string OrderId { get; set; }

        public string BillNumber { get; set; }
    }
}
