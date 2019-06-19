using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PorderProduct
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalAmount { get; set; }
        public int OrderId { get; set; }

        public PurchaseOrder Order { get; set; }
    }
}
