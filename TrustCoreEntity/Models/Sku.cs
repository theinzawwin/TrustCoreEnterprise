using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Sku
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }

        public Categories Category { get; set; }
    }
}
