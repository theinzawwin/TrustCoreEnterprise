using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerAccount = new HashSet<CustomerAccount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Nrc { get; set; }
        public string Phone { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string Crcode { get; set; }

        public ICollection<CustomerAccount> CustomerAccount { get; set; }
    }
}
