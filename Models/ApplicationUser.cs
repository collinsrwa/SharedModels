using Microsoft.AspNetCore.Identity;

namespace SharedModels.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
    }
}