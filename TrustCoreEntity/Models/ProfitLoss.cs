using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class ProfitLoss
    {
        public int Id { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Name { get; set; }
    }
}
