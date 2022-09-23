using OMS.BLL.IBusinessComponent;
using OMS.DAL.IDataAccessRepository;
using OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL.BusinessComponent
{
    public class UserComponent : IUserComponent
    {
        private readonly IUserRepository _userRepository;
        public UserComponent(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> GetUser(UserViewModel model)
        {
            return await _userRepository.GetUser(model);
        }
        public UserViewModel GetUser(string userName, string pass)
        {
            return _userRepository.GetUser(userName, pass);
        }
        public async Task<IEnumerable<UserViewModel>> GetAllUser()
        {
            return await _userRepository.GetAllUser();
        }

        public async Task<IViewModel> AddUser(UserViewModel model)
        {
            IViewModel viewData = new ViewData()
            {
                IsSuccess = false,
                Message = "Error while adding/updating a Add User, please contact Admin for more details."
            };
            try
            {
                var isSuccess = _userRepository.AddUser(model);
                if (isSuccess.Result)
                {
                    viewData.IsSuccess = true;
                    viewData.Message = "User created Successfully. ";
                }
                else
                {
                    viewData.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            return viewData;
        }

        public async Task<IViewModel> UpdateUser(UserViewModel model)
        {
            IViewModel viewData = new ViewData()
            {
                IsSuccess = false,
                Message = "Error while adding/updating a Add User, please contact Admin for more details."
            };
            try
            {
                var isSuccess = _userRepository.UpdateUser(model);
                if (isSuccess.Result)
                {
                    viewData.IsSuccess = true;
                    viewData.Message = "User updated Successfully. ";
                }
                else
                {
                    viewData.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            return viewData;
        }
    }
}
