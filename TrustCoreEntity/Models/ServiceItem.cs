using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class ServiceItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public int? ServiceCategoryId { get; set; }
        public string Barcode { get; set; }
    }
}
