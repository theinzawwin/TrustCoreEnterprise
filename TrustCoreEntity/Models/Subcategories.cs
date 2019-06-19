using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Subcategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
    }
}
