﻿using System;
using System.Collections.Generic;

namespace TrustCoreEntity.Models
{
    public partial class IncomeCategory
    {
        public IncomeCategory()
        {
            Income = new HashSet<Income>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Income> Income { get; set; }
    }
}
