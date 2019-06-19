using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class GrossSummary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public int? TitleId { get; set; }
    }
}
