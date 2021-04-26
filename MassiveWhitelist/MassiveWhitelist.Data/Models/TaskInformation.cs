using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveWhitelist.Data.Models
{
    public class TaskInformation
    {
        public int TaskInformationId { get; set; }
        public string TaskInformationName { get; set; }
        public string TaskInformationDescription { get; set; }
        public decimal TaskPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int TaskGroupId { get; set; }
        public TaskGroup TaskGroup { get; set; }
    }
}
