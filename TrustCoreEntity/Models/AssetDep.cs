using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class AssetDep
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public DateTime? DepDate { get; set; }
        public double? DepPercent { get; set; }
        public double? DepAmount { get; set; }
    }
}
