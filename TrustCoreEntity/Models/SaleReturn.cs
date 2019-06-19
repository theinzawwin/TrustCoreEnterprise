using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class SaleReturn
    {
        public int Id { get; set; }
        public string VoucherNo { get; set; }
        public int? StockId { get; set; }
        public double? SellPrice { get; set; }
        public int? Quantity { get; set; }
        public double TotalAmount { get; set; }
        public string Remark { get; set; }
        public int UserId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CustomerName { get; set; }

        public LoginUser User { get; set; }
    }
}
