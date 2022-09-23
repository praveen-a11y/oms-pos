using OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL.IBusinessComponent
{
    public interface IUserComponent
    {
        Task<UserViewModel> GetUser(UserViewModel model);
        UserViewModel GetUser(string userName, string pass);
        Task<IViewModel> AddUser(UserViewModel model);
        Task<IViewModel> UpdateUser(UserViewModel model);
        Task<IEnumerable<UserViewModel>> GetAllUser();
    }
}
