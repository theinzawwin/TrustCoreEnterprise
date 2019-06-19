using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            DebitSupplier = new HashSet<DebitSupplier>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string SupplierNo { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public DateTime? Date { get; set; }

        public ICollection<DebitSupplier> DebitSupplier { get; set; }
    }
}
