using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OMS.DAL.DataModels;
using OMS.DAL.IDataAccessRepository;
using OMS.Models;
using OMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataAccessRepository
{
    public class ItemRepository: IItemRepository
    {
        private readonly OMSContext _dbContext = null;
        private readonly IMapper _mapper;
        public ItemRepository(OMSContext oMSContext, IMapper mapper)
        {
            _dbContext = oMSContext;
            _mapper = mapper;
        }
        public IEnumerable<ItemListOutletCategoryWiseModel> GetItems(long outletId)
        {
            IEnumerable<ItemListOutletCategoryWiseModel> itemListOutletCategories = null;
            UserViewModel usermodel = new UserViewModel();
            var ItemCategoryIdParam = new SqlParameter("@ItemCategoryId", -1);
            var outletIdParam = new SqlParameter("@OutletId", outletId);

            var result = _dbContext.ItemListOutletCategoryWises            
            .FromSqlRaw("exec GetItemListOutletCategoryWise @ItemCategoryId, @OutletId", ItemCategoryIdParam, outletIdParam).AsEnumerable();

            itemListOutletCategories = _mapper.Map<IEnumerable<ItemListOutletCategoryWiseModel>>(result);

            return itemListOutletCategories;
        }
    }
}
