﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataModels
{
    public partial class LoginCheckResponse
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }        
        public long OutletId { get; set; }

    }
}
