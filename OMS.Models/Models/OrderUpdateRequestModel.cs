using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class OrderUpdateRequestModel
    {
        public long OutletId { get; set; }
        public long OrderId { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
    }
}
