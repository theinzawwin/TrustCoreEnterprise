using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PaySupplier
    {
        public int Id { get; set; }
        public int? SupAccountId { get; set; }
        public DateTime? PayDate { get; set; }
        public double? PayAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? RemainAmount { get; set; }
        public string Remark { get; set; }
        public int? UserId { get; set; }
        public DateTime? SysDate { get; set; }
        public int? PurchaseCreditId { get; set; }
    }
}
