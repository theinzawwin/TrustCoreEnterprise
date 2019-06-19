using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class StockLoss
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int LossQuantity { get; set; }
        public double PurchasePrice { get; set; }
        public string Remark { get; set; }
        public int UserId { get; set; }
        public int? TotalQuantity { get; set; }
        public double? TotalAmount { get; set; }
        public DateTime? Date { get; set; }

        public Stocks Stock { get; set; }
    }
}
