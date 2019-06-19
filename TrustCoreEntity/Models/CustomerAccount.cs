using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class CustomerAccount
    {
        public CustomerAccount()
        {
            PayAccount = new HashSet<PayAccount>();
        }

        public int Id { get; set; }
        public DateTime? OpenDate { get; set; }
        public int? CustomerId { get; set; }
        public double? TotalAmount { get; set; }
        public DateTime? Date { get; set; }

        public Customers Customer { get; set; }
        public ICollection<PayAccount> PayAccount { get; set; }
    }
}
