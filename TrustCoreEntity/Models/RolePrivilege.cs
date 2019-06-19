using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class RolePrivilege
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? PrivilegeId { get; set; }

        public Role Role { get; set; }
    }
}
