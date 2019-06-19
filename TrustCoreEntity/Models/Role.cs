using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Role
    {
        public Role()
        {
            LoginUser = new HashSet<LoginUser>();
            RolePrivilege = new HashSet<RolePrivilege>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<LoginUser> LoginUser { get; set; }
        public ICollection<RolePrivilege> RolePrivilege { get; set; }
    }
}
