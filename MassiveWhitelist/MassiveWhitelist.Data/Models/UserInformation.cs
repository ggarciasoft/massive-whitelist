using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveWhitelist.Data.Models
{
    public class UserInformation
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<GeneralInformationUser> GeneralInformations { get; set; }
    }
}
