using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveWhitelist.Data.Models
{
    public class TaskUser
    {
        public int TaskUserId { get; set; }
        public int TaskInformationId { get; set; }
        public int UserId { get; set; }
        public bool IsCompleted { get; set; }
        public decimal TaskPrice { get; set; }
        public DateTime CompleteDate { get; set; }
        public UserInformation User { get; set; }
        public TaskInformation TaskInformation { get; set; }
    }
}
