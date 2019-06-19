using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Account
    {
        public Account()
        {
            Asset = new HashSet<Asset>();
            Journal = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountTypeId { get; set; }
        public string Description { get; set; }

        public AccountType AccountType { get; set; }
        public ICollection<Asset> Asset { get; set; }
        public ICollection<Journal> Journal { get; set; }
    }
}
