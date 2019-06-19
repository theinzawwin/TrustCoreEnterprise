using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Products
    {
        public Products()
        {
            Stocks = new HashSet<Stocks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Date { get; set; }
        public int? SubcategoryId { get; set; }
        public string Sku { get; set; }

        public ICollection<Stocks> Stocks { get; set; }
    }
}
