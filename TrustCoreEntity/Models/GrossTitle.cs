using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class GrossTitle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
