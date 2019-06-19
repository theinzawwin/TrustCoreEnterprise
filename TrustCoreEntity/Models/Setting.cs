using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string VoucherNo { get; set; }
        public string BackupPath { get; set; }
        public string Crcode { get; set; }
        public double? Tax { get; set; }
        public string Email { get; set; }
        public string InvoiceNo { get; set; }
        public string QuotationNo { get; set; }
    }
}
