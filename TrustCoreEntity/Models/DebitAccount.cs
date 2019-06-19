using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class DebitAccount
    {
        public DebitAccount()
        {
            PayAccount = new HashSet<PayAccount>();
        }

        public int Id { get; set; }
        public int? AccountId { get; set; }
        public DateTime DebitDate { get; set; }
        public double? DebitAmount { get; set; }
        public int? BillId { get; set; }
        public string Status { get; set; }
        public double? RemainAmount { get; set; }
        public DateTime? SysDate { get; set; }

        public Bills Bill { get; set; }
        public ICollection<PayAccount> PayAccount { get; set; }
    }
}
