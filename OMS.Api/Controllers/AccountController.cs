using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMS.BLL.IBusinessComponent;
using OMS.Models;

namespace OMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IUserComponent _userComponent;
        public AccountController(IUserComponent userComponent)
        {
            _userComponent = userComponent;
        }

        [HttpPost("authenticate")]
        public UserModel Authenticate(UserModel bookViewModel)
        {
            return new UserModel
            {
                id = "123",
                username = "admin",
                password = "123",
                firstName = "Praveen",
                lastName = "Pandey",
                token = "string",
            };
        }

        [HttpGet("GetAllUser")]
        public async Task<IEnumerable<UserViewModel>> GetAllUser()
        {
            return await _userComponent.GetAllUser();
        }

        [HttpGet("GetUser")]
        public async Task<UserViewModel> GetUser(UserViewModel model)
        {
            return await _userComponent.GetUser(model);
        }

        [HttpPost("AddUser")]
        public async Task<IViewModel> AddUser(UserViewModel model)
        {
            return await _userComponent.AddUser(model);
        }

        [HttpPost("UpdateUser")]
        public async Task<IViewModel> UpdateUser(UserViewModel model)
        {
            return await _userComponent.UpdateUser(model);
        }
    }
    public class UserModel
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string token { get; set; }
    }
}
