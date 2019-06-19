using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            FocHead = new HashSet<FocHead>();
            ItemDiscount = new HashSet<ItemDiscount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public DateTime? SysDate { get; set; }
        public bool? Status { get; set; }

        public ICollection<FocHead> FocHead { get; set; }
        public ICollection<ItemDiscount> ItemDiscount { get; set; }
    }
}
