using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class TargetDiscount
    {
        public int Id { get; set; }
        public double? TargetAmount { get; set; }
        public int? Status { get; set; }
        public double? DiscountAmount { get; set; }
        public int? ProId { get; set; }
    }
}
