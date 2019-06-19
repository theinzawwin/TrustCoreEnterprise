using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PurchaseCredit
    {
        public int Id { get; set; }
        public int SupplierAccountId { get; set; }
        public DateTime? Date { get; set; }
        public double? CreditAmount { get; set; }
        public int? PurchaseInvoiceId { get; set; }
        public string Status { get; set; }
        public double? RemainAmount { get; set; }
        public DateTime? SysDate { get; set; }
        public int? UserId { get; set; }

        public DebitSupplier SupplierAccount { get; set; }
    }
}
