using System.Collections.Generic;

namespace SampleWebApp.B2c.Models
{
    public class UserProfileResponse
    {
        // Optional claims
        public string Email { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Roles {get;set;}

        public UserProfileResponse()
        {
            Roles = string.Join(",", new string[] { "Role1", "Role2" });
        }
    }
}