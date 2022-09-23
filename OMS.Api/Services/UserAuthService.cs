using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OMS.BLL.IBusinessComponent;
using OMS.Models;
using OMS.Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OMS.Api.Services
{
    public interface IUserAuthService
    {
        UserAuthResponse Authenticate(UserLoginInputModel model);
    }
    public class UserAuthService : IUserAuthService
    {
        private readonly IUserComponent userComponent;
        private readonly AppSettings _appSettings;

        public UserAuthService(IOptions<AppSettings> appSettings, IUserComponent userComponent)
        {
            _appSettings = appSettings.Value;
            this.userComponent = userComponent;
        }

        public UserAuthResponse Authenticate(UserLoginInputModel model)
        {
            var user = userComponent.GetUser(model.Username, model.Password);

            // return null if user not found
            if (user != null && user.UserId != Guid.Empty)
            {
                var token = generateJwtToken(user);
                return new UserAuthResponse(user, token);
            }
            return null;
        }

        private string generateJwtToken(UserViewModel user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
