using System;
using System.Collections.Generic;

namespace OMS.DAL.DataModels
{
    public partial class FormMaster
    {
        public long FormId { get; set; }
        public string FormGroup { get; set; } = null!;
        public string FormName { get; set; } = null!;
        public string FormDescription { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
