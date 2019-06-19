using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Income
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public string Description { get; set; }
        public DateTime? IncomeDate { get; set; }
        public DateTime? SysDate { get; set; }
        public int? IncomeCatId { get; set; }
        public int? UserId { get; set; }

        public IncomeCategory IncomeCat { get; set; }
    }
}
