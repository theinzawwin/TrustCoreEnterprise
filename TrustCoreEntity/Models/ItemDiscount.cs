using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class ItemDiscount
    {
        public int Id { get; set; }
        public int? StockId { get; set; }
        public int? Status { get; set; }
        public double? DiscountAmount { get; set; }
        public int? ProId { get; set; }

        public Promotion Pro { get; set; }
    }
}
