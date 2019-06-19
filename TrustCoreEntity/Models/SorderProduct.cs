using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class SorderProduct
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public double? TotalAmount { get; set; }
        public int OrderId { get; set; }
        public double? NetAmount { get; set; }
        public double? Discount { get; set; }

        public Stocks Stock { get; set; }
    }
}
