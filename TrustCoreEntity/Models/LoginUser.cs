using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class LoginUser
    {
        public LoginUser()
        {
            Bills = new HashSet<Bills>();
            SaleReturn = new HashSet<SaleReturn>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public bool? Status { get; set; }
        public string DelStatus { get; set; }

        public Role Role { get; set; }
        public ICollection<Bills> Bills { get; set; }
        public ICollection<SaleReturn> SaleReturn { get; set; }
    }
}
