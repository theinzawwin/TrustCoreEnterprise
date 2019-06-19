using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Journal
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? JournalDate { get; set; }
        public string AccountStatus { get; set; }
        public int? RefId { get; set; }
        public string Description { get; set; }

        public Account Account { get; set; }
    }
}
