using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PurchaseReturn
    {
        public int Id { get; set; }
        public int? StockId { get; set; }
        public int? Quantity { get; set; }
        public double? PurchasePrice { get; set; }
        public string Remark { get; set; }
        public double? TotalPurchasePrice { get; set; }
        public string Status { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? UserId { get; set; }
        public string RefNo { get; set; }
    }
}
