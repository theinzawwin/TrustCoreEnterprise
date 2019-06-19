using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class FocPay
    {
        public int Id { get; set; }
        public int? FocId { get; set; }
        public int? StockId { get; set; }
        public int? Qty { get; set; }

        public FocHead Foc { get; set; }
    }
}
