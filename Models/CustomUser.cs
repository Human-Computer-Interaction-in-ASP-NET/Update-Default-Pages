using Microsoft.AspNetCore.Identity;

namespace SeedIdentity.Models
{
    public class CustomUser : IdentityUser
    {
        public CustomUser() : base() { }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}