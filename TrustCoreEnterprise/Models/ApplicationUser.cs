﻿using Microsoft.AspNetCore.Identity;

namespace TrustCoreEnterprise.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        
    }
}
