using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveWhitelist.Data.Models
{
    public class TaskGroup
    {
        public int TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
        public string TaskGroupDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
