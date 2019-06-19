using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PurchaseItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public int StockId { get; set; }
        public double? TotalAmount { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? SupplierId { get; set; }
        public double? PayAmount { get; set; }
        public double? RemainAmount { get; set; }
        public int? UserId { get; set; }
        public string RefNo { get; set; }
        public int? PurchaseInvoiceId { get; set; }

        public Stocks Stock { get; set; }
    }
}
