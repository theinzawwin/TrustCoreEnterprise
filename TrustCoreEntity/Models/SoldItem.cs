using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class SoldItem
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalAmount { get; set; }
        public DateTime SellDate { get; set; }
        public int? DebtId { get; set; }
        public int? BillId { get; set; }
        public double? DiscountAmount { get; set; }
        public double? NetAmount { get; set; }
        public string Status { get; set; }

        public Stocks Stock { get; set; }
    }
}
