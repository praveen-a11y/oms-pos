using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OMS.DAL.DataModels;
using OMS.DAL.IDataAccessRepository;
using OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.DAL.DataAccessRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly OMSContext _dbContext = null;
        public UserRepository(OMSContext oMSContext)
        {
            _dbContext = oMSContext;
        }


        public UserViewModel GetUser(string userName, string pass)
        {
            UserViewModel usermodel = new UserViewModel();
            var userNameParam = new SqlParameter("@UserName", userName);
            var passwordParam = new SqlParameter("@Password", pass);

            var result = _dbContext
            .LoginCheckResponses
            .FromSqlRaw("exec proc_LoginCheck @UserName, @Password", userNameParam, passwordParam).AsEnumerable()
            .FirstOrDefault();


            
            if (result != null)
            {
                usermodel.UserId = result.UserId;
                usermodel.UserName = result.UserName;
                usermodel.OutletId = result.OutletId;
            }

            return usermodel;
        }

        public Task<bool> AddUser(UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> GetUser(UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserViewModel>> GetAllUser()
        {
            throw new NotImplementedException();
        }
    }
}
