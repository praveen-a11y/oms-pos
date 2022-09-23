using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models
{
    public class ViewData : IViewModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
