using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class DebitSupplier
    {
        public DebitSupplier()
        {
            PurchaseCredit = new HashSet<PurchaseCredit>();
        }

        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }

        public Supplier Supplier { get; set; }
        public ICollection<PurchaseCredit> PurchaseCredit { get; set; }
    }
}
