using OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.IDataAccessRepository
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetUser(UserViewModel model);
        UserViewModel GetUser(string userName, string pass);
        Task<bool> AddUser(UserViewModel model);
        Task<bool> UpdateUser(UserViewModel model);
        Task<IEnumerable<UserViewModel>> GetAllUser();

    }
}
