using Microsoft.AspNetCore.Identity;

namespace TrustCoreEntity.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        
    }
}
