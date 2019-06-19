using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Finance
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? CustomerId { get; set; }
        public int? PayAccountId { get; set; }
        public double? TotalAmount { get; set; }
        public double? RemainAmount { get; set; }
    }
}
