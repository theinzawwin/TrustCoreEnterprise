using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Privilege
    {
        public int Id { get; set; }
        public string PrivilegeName { get; set; }
        public string PrivilegeShortName { get; set; }
    }
}
