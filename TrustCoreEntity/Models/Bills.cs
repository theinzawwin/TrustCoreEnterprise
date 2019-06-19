using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Bills
    {
        public Bills()
        {
            DebitAccount = new HashSet<DebitAccount>();
        }

        public int Id { get; set; }
        public DateTime BillDate { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double TaxAmount { get; set; }
        public double PayAmount { get; set; }
        public double RemainAmount { get; set; }
        public int? CustomerId { get; set; }
        public double? RefundAmount { get; set; }
        public string VoucherNo { get; set; }
        public string BillTime { get; set; }
        public int CashierId { get; set; }
        public double? SubTotalAmount { get; set; }
        public double? NetTotalAmount { get; set; }
        public string SaleStatus { get; set; }
        public double? VoucherDisPercent { get; set; }
        public double? VoucherDisAmount { get; set; }

        public LoginUser Cashier { get; set; }
        public ICollection<DebitAccount> DebitAccount { get; set; }
    }
}
