using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Sku = new HashSet<Sku>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public ICollection<Sku> Sku { get; set; }
    }
}
