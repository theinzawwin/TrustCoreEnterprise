using System;
using System.Collections.Generic;
using System.Text;
using TrustCoreDao.ViewModel;

namespace TrustCoreDao.Repository
{
    public interface IProductManager
    {
        void Save(ProductViewModel product);
    }
}
