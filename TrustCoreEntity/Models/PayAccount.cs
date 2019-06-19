using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PayAccount
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public DateTime? PayDate { get; set; }
        public double? PayAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? RemainAmount { get; set; }
        public int? UserId { get; set; }
        public int? DebitAccountId { get; set; }
        public DateTime? SysDate { get; set; }

        public CustomerAccount Account { get; set; }
        public DebitAccount DebitAccount { get; set; }
    }
}
