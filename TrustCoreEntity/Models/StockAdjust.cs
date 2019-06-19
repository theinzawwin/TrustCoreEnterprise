using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class StockAdjust
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public int? AdjustQuantity { get; set; }
        public string Reason { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public int? HandQuantity { get; set; }
    }
}
