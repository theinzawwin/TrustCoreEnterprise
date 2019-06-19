using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class SaleOrder
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public string SaleType { get; set; }
        public string SaleStatus { get; set; }
        public double? DiscountPercent { get; set; }
        public double? DiscountAmount { get; set; }
        public int? UserId { get; set; }
    }
}
