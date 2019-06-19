using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public DateTime? SysDate { get; set; }
        public int ExpenseCategoryId { get; set; }
        public string Status { get; set; }
        public int? UserId { get; set; }

        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
