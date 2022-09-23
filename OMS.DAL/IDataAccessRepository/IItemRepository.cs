using OMS.Models;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.IDataAccessRepository
{
    public interface IItemRepository
    {
        IEnumerable<ItemListOutletCategoryWiseModel> GetItems(long outletId);
    }
}
