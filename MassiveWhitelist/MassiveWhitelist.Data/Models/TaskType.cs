using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveWhitelist.Data.Models
{
    public class TaskType
    {
        public int TaskTypeId { get; set; }
        public string TaskTypeName { get; set; }
        public string TaskTypeDescription { get; set; }
        public string TaskTypeKey { get; set; }
    }
}
