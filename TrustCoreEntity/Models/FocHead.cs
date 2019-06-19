using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class FocHead
    {
        public FocHead()
        {
            FocPay = new HashSet<FocPay>();
            FocSell = new HashSet<FocSell>();
        }

        public int Id { get; set; }
        public int? ProId { get; set; }
        public string Status { get; set; }

        public Promotion Pro { get; set; }
        public ICollection<FocPay> FocPay { get; set; }
        public ICollection<FocSell> FocSell { get; set; }
    }
}
