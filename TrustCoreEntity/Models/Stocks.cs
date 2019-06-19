using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Stocks
    {
        public Stocks()
        {
            PurchaseItem = new HashSet<PurchaseItem>();
            SoldItem = new HashSet<SoldItem>();
            SorderProduct = new HashSet<SorderProduct>();
            StockLoss = new HashSet<StockLoss>();
        }

        public int Id { get; set; }
        public string Barcode { get; set; }
        public double? PurchasePrice { get; set; }
        public double? SellPrice { get; set; }
        public int? Quantity { get; set; }
        public int ProductId { get; set; }
        public int? Discount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double? BulkSellPrice { get; set; }
        public int? BulkQuantity { get; set; }
        public int? MinimumQuantity { get; set; }
        public int? RetFormula { get; set; }
        public double? RetAmount { get; set; }
        public int? BulkFormula { get; set; }
        public double? BulkAmount { get; set; }

        public Products Product { get; set; }
        public ICollection<PurchaseItem> PurchaseItem { get; set; }
        public ICollection<SoldItem> SoldItem { get; set; }
        public ICollection<SorderProduct> SorderProduct { get; set; }
        public ICollection<StockLoss> StockLoss { get; set; }
    }
}
