using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            Expense = new HashSet<Expense>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Expense> Expense { get; set; }
    }
}
