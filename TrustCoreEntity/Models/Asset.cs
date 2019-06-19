using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Asset
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public double? Debit { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public bool? Status { get; set; }
        public string Description { get; set; }
        public double? Credit { get; set; }
        public string AccountStatus { get; set; }

        public Account Account { get; set; }
    }
}
