using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OMS.BLL.IBusinessComponent;
using OMS.DAL.IDataAccessRepository;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL.BusinessComponent
{
    public class ItemComponent : IItemComponent
    {
        private readonly IItemRepository _itemRepository = null;
        public ItemComponent(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public IEnumerable<CategoryListOutletWiseModel> GetItems(long outletId)
        {
            return this.GetCategoryItems(outletId);
        }

        public IEnumerable<CategoryListOutletWiseModel> GetCategoryItems(long outletId)
        {
            IEnumerable<CategoryListOutletWiseModel> categoryItems = null;
            var allItems = _itemRepository.GetItems(outletId);
            categoryItems = allItems.GroupBy(x => new { x.ItemCategoryId, x.ItemCategoryName }).
                Select(x => new CategoryListOutletWiseModel { ItemCategoryId = x.Key.ItemCategoryId, ItemCategoryName = x.Key.ItemCategoryName,
                 Items = x.Select(x => new ItemListOutletWiseModel { ItemCategoryId = x.ItemCategoryId, ItemID = x.ItemID, ItemName = x.ItemName, ItemPrice = x.ItemPrice, TaxPercent = x.TaxPercent  })
                });
            return categoryItems;
        }
    }
}
