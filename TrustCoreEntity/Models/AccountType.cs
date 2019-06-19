using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Account = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
