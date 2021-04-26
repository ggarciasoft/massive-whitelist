using System;

namespace MassiveWhitelist.Data.Models
{
    public class GeneralInformationUser
    {
        public int GeneralInformationUserId { get; set; }
        public int UserId { get; set; }
        public int GeneralInformationTypeId { get; set; }
        public string GeneralInformationValue { get; set; }
        public DateTime SetDate { get; set; }
        public UserInformation User { get; set; }
        public GeneralInformationType GeneralInformationType { get; set; }
    }
}
