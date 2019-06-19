using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PorderProduct = new HashSet<PorderProduct>();
        }

        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public int SupplierId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string Address { get; set; }

        public ICollection<PorderProduct> PorderProduct { get; set; }
    }
}
