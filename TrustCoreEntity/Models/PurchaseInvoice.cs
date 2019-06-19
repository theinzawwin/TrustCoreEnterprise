using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PurchaseInvoice
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public double TotalAmount { get; set; }
        public double? DiscountAmount { get; set; }
        public double NetTotalAmount { get; set; }
        public double? PayAmount { get; set; }
        public double? RemainAmount { get; set; }
        public string Remark { get; set; }
        public int? SupplierId { get; set; }
        public int? UserId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
